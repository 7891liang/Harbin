﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_QualitySettingsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("QualitySettings");
		L.RegFunction("GetQualityLevel", GetQualityLevel);
		L.RegFunction("SetQualityLevel", SetQualityLevel);
		L.RegFunction("IncreaseLevel", IncreaseLevel);
		L.RegFunction("DecreaseLevel", DecreaseLevel);
		L.RegFunction("__eq", op_Equality);
		L.RegVar("names", get_names, null);
		L.RegFunction("getnames", get_names);
		L.RegVar("pixelLightCount", get_pixelLightCount, set_pixelLightCount);
		L.RegFunction("getpixelLightCount", get_pixelLightCount);
		L.RegFunction("setpixelLightCount", set_pixelLightCountter);
		L.RegVar("shadows", get_shadows, set_shadows);
		L.RegFunction("getshadows", get_shadows);
		L.RegFunction("setshadows", set_shadowster);
		L.RegVar("shadowProjection", get_shadowProjection, set_shadowProjection);
		L.RegFunction("getshadowProjection", get_shadowProjection);
		L.RegFunction("setshadowProjection", set_shadowProjectionter);
		L.RegVar("shadowCascades", get_shadowCascades, set_shadowCascades);
		L.RegFunction("getshadowCascades", get_shadowCascades);
		L.RegFunction("setshadowCascades", set_shadowCascadester);
		L.RegVar("shadowDistance", get_shadowDistance, set_shadowDistance);
		L.RegFunction("getshadowDistance", get_shadowDistance);
		L.RegFunction("setshadowDistance", set_shadowDistanceter);
		L.RegVar("shadowResolution", get_shadowResolution, set_shadowResolution);
		L.RegFunction("getshadowResolution", get_shadowResolution);
		L.RegFunction("setshadowResolution", set_shadowResolutionter);
		L.RegVar("shadowNearPlaneOffset", get_shadowNearPlaneOffset, set_shadowNearPlaneOffset);
		L.RegFunction("getshadowNearPlaneOffset", get_shadowNearPlaneOffset);
		L.RegFunction("setshadowNearPlaneOffset", set_shadowNearPlaneOffsetter);
		L.RegVar("shadowCascade2Split", get_shadowCascade2Split, set_shadowCascade2Split);
		L.RegFunction("getshadowCascade2Split", get_shadowCascade2Split);
		L.RegFunction("setshadowCascade2Split", set_shadowCascade2Splitter);
		L.RegVar("shadowCascade4Split", get_shadowCascade4Split, set_shadowCascade4Split);
		L.RegFunction("getshadowCascade4Split", get_shadowCascade4Split);
		L.RegFunction("setshadowCascade4Split", set_shadowCascade4Splitter);
		L.RegVar("masterTextureLimit", get_masterTextureLimit, set_masterTextureLimit);
		L.RegFunction("getmasterTextureLimit", get_masterTextureLimit);
		L.RegFunction("setmasterTextureLimit", set_masterTextureLimitter);
		L.RegVar("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering);
		L.RegFunction("getanisotropicFiltering", get_anisotropicFiltering);
		L.RegFunction("setanisotropicFiltering", set_anisotropicFilteringter);
		L.RegVar("lodBias", get_lodBias, set_lodBias);
		L.RegFunction("getlodBias", get_lodBias);
		L.RegFunction("setlodBias", set_lodBiaster);
		L.RegVar("maximumLODLevel", get_maximumLODLevel, set_maximumLODLevel);
		L.RegFunction("getmaximumLODLevel", get_maximumLODLevel);
		L.RegFunction("setmaximumLODLevel", set_maximumLODLevelter);
		L.RegVar("particleRaycastBudget", get_particleRaycastBudget, set_particleRaycastBudget);
		L.RegFunction("getparticleRaycastBudget", get_particleRaycastBudget);
		L.RegFunction("setparticleRaycastBudget", set_particleRaycastBudgetter);
		L.RegVar("softParticles", get_softParticles, set_softParticles);
		L.RegFunction("getsoftParticles", get_softParticles);
		L.RegFunction("setsoftParticles", set_softParticlester);
		L.RegVar("softVegetation", get_softVegetation, set_softVegetation);
		L.RegFunction("getsoftVegetation", get_softVegetation);
		L.RegFunction("setsoftVegetation", set_softVegetationter);
		L.RegVar("realtimeReflectionProbes", get_realtimeReflectionProbes, set_realtimeReflectionProbes);
		L.RegFunction("getrealtimeReflectionProbes", get_realtimeReflectionProbes);
		L.RegFunction("setrealtimeReflectionProbes", set_realtimeReflectionProbester);
		L.RegVar("billboardsFaceCameraPosition", get_billboardsFaceCameraPosition, set_billboardsFaceCameraPosition);
		L.RegFunction("getbillboardsFaceCameraPosition", get_billboardsFaceCameraPosition);
		L.RegFunction("setbillboardsFaceCameraPosition", set_billboardsFaceCameraPositionter);
		L.RegVar("maxQueuedFrames", get_maxQueuedFrames, set_maxQueuedFrames);
		L.RegFunction("getmaxQueuedFrames", get_maxQueuedFrames);
		L.RegFunction("setmaxQueuedFrames", set_maxQueuedFramester);
		L.RegVar("vSyncCount", get_vSyncCount, set_vSyncCount);
		L.RegFunction("getvSyncCount", get_vSyncCount);
		L.RegFunction("setvSyncCount", set_vSyncCountter);
		L.RegVar("antiAliasing", get_antiAliasing, set_antiAliasing);
		L.RegFunction("getantiAliasing", get_antiAliasing);
		L.RegFunction("setantiAliasing", set_antiAliasingter);
		L.RegVar("desiredColorSpace", get_desiredColorSpace, null);
		L.RegFunction("getdesiredColorSpace", get_desiredColorSpace);
		L.RegVar("activeColorSpace", get_activeColorSpace, null);
		L.RegFunction("getactiveColorSpace", get_activeColorSpace);
		L.RegVar("blendWeights", get_blendWeights, set_blendWeights);
		L.RegFunction("getblendWeights", get_blendWeights);
		L.RegFunction("setblendWeights", set_blendWeightster);
		L.RegVar("asyncUploadTimeSlice", get_asyncUploadTimeSlice, set_asyncUploadTimeSlice);
		L.RegFunction("getasyncUploadTimeSlice", get_asyncUploadTimeSlice);
		L.RegFunction("setasyncUploadTimeSlice", set_asyncUploadTimeSliceter);
		L.RegVar("asyncUploadBufferSize", get_asyncUploadBufferSize, set_asyncUploadBufferSize);
		L.RegFunction("getasyncUploadBufferSize", get_asyncUploadBufferSize);
		L.RegFunction("setasyncUploadBufferSize", set_asyncUploadBufferSizeter);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetQualityLevel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = UnityEngine.QualitySettings.GetQualityLevel();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetQualityLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				UnityEngine.QualitySettings.SetQualityLevel(arg0);
				return 0;
			}
			else if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				UnityEngine.QualitySettings.SetQualityLevel(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.SetQualityLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IncreaseLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.QualitySettings.IncreaseLevel();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				UnityEngine.QualitySettings.IncreaseLevel(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.IncreaseLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecreaseLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.QualitySettings.DecreaseLevel();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				UnityEngine.QualitySettings.DecreaseLevel(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.DecreaseLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_names(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.names);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pixelLightCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.pixelLightCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadows(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.shadows);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowProjection(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.shadowProjection);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascades(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.shadowCascades);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowResolution(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.shadowResolution);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNearPlaneOffset(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowNearPlaneOffset);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascade2Split(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowCascade2Split);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascade4Split(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadowCascade4Split);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_masterTextureLimit(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.masterTextureLimit);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisotropicFiltering(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.anisotropicFiltering);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lodBias(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.lodBias);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumLODLevel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.maximumLODLevel);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_particleRaycastBudget(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.particleRaycastBudget);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softParticles(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.softParticles);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softVegetation(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.softVegetation);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeReflectionProbes(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.realtimeReflectionProbes);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_billboardsFaceCameraPosition(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.billboardsFaceCameraPosition);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxQueuedFrames(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.maxQueuedFrames);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vSyncCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.vSyncCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_antiAliasing(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.antiAliasing);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_desiredColorSpace(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.desiredColorSpace);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeColorSpace(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.activeColorSpace);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_blendWeights(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)UnityEngine.QualitySettings.blendWeights);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadTimeSlice(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.asyncUploadTimeSlice);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadBufferSize(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.asyncUploadBufferSize);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pixelLightCount(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.pixelLightCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pixelLightCountter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.pixelLightCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadows(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowQuality arg0 = (UnityEngine.ShadowQuality)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadows = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowster(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowQuality arg0 = (UnityEngine.ShadowQuality)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadows = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowProjection(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowProjection arg0 = (UnityEngine.ShadowProjection)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowProjection = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowProjectionter(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowProjection arg0 = (UnityEngine.ShadowProjection)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadowProjection = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascades(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowCascades = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascadester(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadowCascades = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowDistanceter(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadowDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowResolution(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowResolution arg0 = (UnityEngine.ShadowResolution)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowResolution = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowResolutionter(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowResolution arg0 = (UnityEngine.ShadowResolution)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadowResolution = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNearPlaneOffset(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowNearPlaneOffset = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNearPlaneOffsetter(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadowNearPlaneOffset = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade2Split(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowCascade2Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade2Splitter(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.shadowCascade2Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade4Split(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.QualitySettings.shadowCascade4Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade4Splitter(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.QualitySettings.shadowCascade4Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimit(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.masterTextureLimit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimitter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.masterTextureLimit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFiltering(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.anisotropicFiltering = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFilteringter(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.anisotropicFiltering = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lodBias(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.lodBias = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lodBiaster(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.lodBias = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumLODLevel(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.maximumLODLevel = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumLODLevelter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.maximumLODLevel = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_particleRaycastBudget(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.particleRaycastBudget = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_particleRaycastBudgetter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.particleRaycastBudget = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softParticles(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.softParticles = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softParticlester(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			UnityEngine.QualitySettings.softParticles = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softVegetation(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.softVegetation = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softVegetationter(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			UnityEngine.QualitySettings.softVegetation = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_realtimeReflectionProbes(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.realtimeReflectionProbes = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_realtimeReflectionProbester(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			UnityEngine.QualitySettings.realtimeReflectionProbes = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_billboardsFaceCameraPosition(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_billboardsFaceCameraPositionter(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxQueuedFrames(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.maxQueuedFrames = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxQueuedFramester(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.maxQueuedFrames = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_vSyncCount(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.vSyncCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_vSyncCountter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.vSyncCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_antiAliasing(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.antiAliasing = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_antiAliasingter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.antiAliasing = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_blendWeights(IntPtr L)
	{
		try
		{
			UnityEngine.BlendWeights arg0 = (UnityEngine.BlendWeights)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.blendWeights = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_blendWeightster(IntPtr L)
	{
		try
		{
			UnityEngine.BlendWeights arg0 = (UnityEngine.BlendWeights)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.blendWeights = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadTimeSlice(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.asyncUploadTimeSlice = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadTimeSliceter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.asyncUploadTimeSlice = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadBufferSize(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.asyncUploadBufferSize = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadBufferSizeter(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.QualitySettings.asyncUploadBufferSize = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
