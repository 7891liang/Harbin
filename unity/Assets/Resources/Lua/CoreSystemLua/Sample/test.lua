require("strict")
pcall(require, "socket")

local timeout
local conf = { 
  time = socket and socket.gettime or os.time,
  setTimeout = function (fn, delay)
    assert(not timeout)
    timeout = { 
      f = function ()
        timeout = nil
        fn()
      end, 
      delay = delay 
    }
    return timeout
  end,
  clearTimeout = function (id)
		assert(timeout == id)
		timeout = nil
  end
}

local function runTimeout()
	local now = conf.time()
  while true do
    if (conf.time() - now) * 1000 >= timeout.delay then
      timeout.f()
      break
    end
  end
end

require("All")("", conf)
collectgarbage("collect")
print(collectgarbage("count"))

local function test(f, name) 
  print("-----------------------------", name)
  f()
  print("\n")
end

local function printList(list)
  assert(list)
  local t = {}
  for _, i in System.each(list) do
    table.insert(t, i:ToString())
  end
  print(table.concat(t, " "))
end

local function testDateTimeAndTimeSpan() 
  local date = System.DateTime.getNow()
  print(date:getTicks())
  print(date:ToString(), date:getYear(), date:getMonth(), date:getDay(), date:getHour(), date:getMinute(), date:getSecond())
    
  local ts = System.TimeSpan.FromSeconds(20)
  print(ts:ToString())
    
  date = date + System.TimeSpan.FromDays(2)
  print(date:ToString())
  
  date = date:AddMonths(2);
  print(date:ToString())
    
  local baseTime = System.DateTime(1970, 1, 1) 
  print(baseTime:ToString())
  print(baseTime:AddMilliseconds(1458032204643):ToString())
end

local function testArray() 
  local arr = System.Array(System.Int):new(10)
  print(arr:ToString(), #arr)
  printList(arr)
  arr:set(0, 2)
  arr:set(6, 4)
  printList(arr)
  print(arr:get(0), arr:get(6), arr:get(9))
end

local function testList()
  local list = System.List(System.Int)()
  list:Add(20)
  list:Add(15)
  list:Add(6)
  print(list:ToString(), #list)
  printList(list)
  local subList = list:GetRange(1, 2)
  printList(subList)
  list:set(1, 8)
  list:Sort()
  printList(list)
  print(list:Contains(10), list:Contains(15), list:IndexOf(20))
  list:RemoveAll(function(i) return i >= 10 end)
  print(#list, list:get(1))
  printList(list)
end

local function testDictionary()
  local dict = System.Dictionary(System.String, System.Int)()
  dict:Add("a", 1)
  dict:Add("b", 12)
  dict:Add("c", 25)
  dict:Add("d", 30)
  for _,  pair in System.each(dict) do
    print(pair.Key, pair.Value)
  end
  print("-------------")
  for k, v in System.pairs(dict) do
     print(k, v)
  end
end

local function testYeild()
  local enumerable = function (begin, _end) 
    return System.yieldIEnumerable(function (begin, _end)
      while begin < _end do
        System.yieldReturn(begin)
        begin = begin + 1
      end
    end, System.Int, begin, _end)
  end
  local e = enumerable(1, 10)
  printList(e)
  printList(e)
end

local function testDelegate()
  local prints = ""
  local function printExt(s)
    prints = prints .. s
    print(s)
  end

  local function assertExt(s)
    assert(prints == s, s)
    prints = ""
  end

  local d1 = function() printExt("d1") end
  local d2 = function() printExt("d2") end
  local d3 = function() printExt("d3") end

  local f = nil + d1 
  f()
  assertExt("d1") 
  print("--")
  
  f = d1 + nil
  f()
  assertExt("d1")
  print("--")
  
  f = d1 + d2
  f()
  assertExt("d1d2")
  print("--")
   
  f = d1 + (d2 + d3) 
  f()
  assertExt("d1d2d3")
  print("--")
     
  f = (d1 + d2) + (d2 + d3)  
  f()
  assertExt("d1d2d2d3")
  print("--")
  
  f = d1 + d2 - d1  
  f()
  assertExt("d2")
  print("--")
   
  f = d1 + d2 - d2 
  f()
  assertExt("d1")
  print("--")
   
  f = d1 + d2 + d1 - d1
  f()
  assertExt("d1d2")
  print("--")
    
   
  f = d1 + d2 + d3 - (d1 + d2) 
  f()
  assertExt("d3")
  print("--")
    
  f = d1 + d2 + d3 - (d2 + d1)
  f()
  assertExt("d1d2d3")
  print("--")
   
  f = (d1 + d2) + (d3 + d1 + d2) 
  local f1 = d1 + d2
  f = f - f1
  f()
  assertExt("d1d2d3")
    
  print("--")
  f = (d1 + d2) - (d1 + d2)
  print(f == nil)
end

local function testLinq()
  local Linq = System.Linq.Enumerable
  local list = System.List(System.Int)()
  list:Add(10) list:Add(2) list:Add(30) list:Add(4) list:Add(5) list:Add(6) list:Add(7) list:Add(8)
  printList(Linq.Where(list, function(i) return i >= 4 end))
  printList(Linq.Take(list, 4))
  printList(Linq.Select(list, function(i) return i + 2 end, System.Int))
  print(Linq.Min(list), Linq.Max(list))
  print(Linq.ElementAtOrDefault(Linq.Where(list, function(i) return i <= 4 end), 5))
  local ll = Linq.Where(list, function(i) return i <= 4 end)
  print(Linq.Count(ll))
  Linq.Any(ll)
  print(Linq.Count(ll))
    
  printList(Linq.OrderByDescending(list, function(i) return i end, nil, System.Int))  
  list = System.List(System.Object)()
  local super = { 
    ToString = function(t)
      return t[1] .. ',' .. t[2] .. ',' .. t[3] .. '|'
    end
  }
  super.__index = super 
    
  list:Add(setmetatable({ 4, 2, 3 }, super))
  list:Add(setmetatable({ 3, 1, 3 }, super))
  list:Add(setmetatable({ 1, 2, 3 }, super))
  list:Add(setmetatable({ 3, 2, 4 }, super))
  list:Add(setmetatable({ 3, 2, 3 }, super))
    
  local t1 = Linq.OrderBy(list, function(i) return i[1] end, nil, System.Int)  
  printList(t1)
  t1 = Linq.ThenBy(t1, function(i) return i[2] end, nil, System.Int)
  t1 = Linq.ThenBy(t1, function(i) return i[3] end, nil, System.Int)
  printList(t1)
end 

local function testGroupBy() 
  local Linq = System.Linq.Enumerable
  local list = System.List(System.Object)()
  list:Add({ id = 5, Template = 30 })
  list:Add({ id = 6, Template = 30 })
  list:Add({ id = 1, Template = 1 })
  list:Add({ id = 2, Template = 2 })
  list:Add({ id = 3, Template = 1 })
  list:Add({ id = 4, Template = 2 })
  local groups = Linq.GroupBy(list, function (i) return i.Template end, System.Int)
  local s = ""
  for _,  group in System.each(groups) do
    for _, item in System.each(group) do
      s = s .. item.id
    end
  end
  print(s)
  assert(s == "561324");
end

local function testType()
  local ins = 2
  print(System.is(ins, System.Double))
  local t = ins:GetType()
  print(t:getName())
  print(System.is("ddd", System.String))
  print(System.as("ddd", System.String))
  print(System.cast(System.String, "ddd"))
end

local function testNumCast()
  assert(System.toInt32(-2147483659) == 2147483637)
  assert(System.toUInt32(-2147483659) == 2147483637)
  assert(System.toUInt64(-1) == 18446744073709551615)
end

local function testSplit()
  local a = "a, b"
  local aa = a:Split(44 --[[',']])
  printList(aa)
end

local function testConsole()
  print("enter your name")
  local name = System.Console.ReadLine()
  print("enter your age")
  local age = System.Console.ReadLine()
  System.Console.WriteLine("name {0}, age {1}", name, age)
end

local function testIO()
  local path = "iotest.txt"
  local s = "hero, CSharp.lua\nIO"
  local File = System.IO.File
  File.WriteAllText(path, s)
  local text = File.ReadAllText(path)
  assert(text == s)
  os.remove(path)
end

local function testStringBuilder()
  local sb = System.StringBuilder()
  sb:Append("aa")
  sb:Append("bbcc")
  sb:setLength(5)  
  print(sb, sb:getLength())
end

local function testAsync()  
	-- Generated by CSharp.lua Compiler
	local System = System
	local Test
	System.usingDeclare(function (global)
		Test = global.Test
	end)
	System.namespace("Test", function (namespace)
		namespace.class("TestAsync", function (namespace)
			local f, __ctor__
			__ctor__ = function (this)
				local t = f(this)
				System.Console.WriteLine(("{0}, {1}"):Format(t:getStatus():ToEnumString(System.TaskStatus), t:getException()))
			end
			f = function (this)
				return System.async(function (async, this)
					local t = System.Task.Delay(2000)
					async:await(t)
					async:await(t)
					System.Console.WriteLine(("Delay {0}"):Format(t:getStatus():ToEnumString(System.TaskStatus)))
				end, this)
			end
			return {
				f = f,
				__ctor__ = __ctor__
			}
		end)

		namespace.class("Program", function (namespace)
			local Main
			Main = function ()
				Test.TestAsync()
			end
			return {
				Main = Main
			}
		end)
	end)

	System.init({
		"Test.Program",
		"Test.TestAsync"
	}, {
		Main = "Test.Program.Main"
	})

	Test.Program.Main() 
  runTimeout()
end

test(testDateTimeAndTimeSpan, "DateTime & TimeSpan")
test(testArray, "Array")
test(testList, "List")
test(testDictionary, "Dictionary")
test(testYeild, "Yeild")
test(testDelegate, "Delegate")
test(testLinq, "Linq")
test(testGroupBy, "GroupBy")
test(testType, "Type")
--test(testNumCast, "NumCast")
--test(testSplit, "testSplit")
--test(testStringBuilder, "StringBuilder")
--test(testConsole, "Console")
--test(testIO, "IO")
test(testAsync, "Async")



