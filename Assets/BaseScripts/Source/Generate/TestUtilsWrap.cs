﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestUtilsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestUtils), typeof(System.Object));
		L.RegFunction("Load", Load);
		L.RegFunction("New", _CreateTestUtils);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTestUtils(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TestUtils obj = new TestUtils();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TestUtils.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.GameObject o = TestUtils.Load(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

