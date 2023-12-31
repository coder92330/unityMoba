﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGBattleUnitController_UnitBuffWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGBattleUnitController.UnitBuff), typeof(System.Object));
		L.RegFunction("New", _CreateNTGBattleUnitController_UnitBuff);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("icon", get_icon, set_icon);
		L.RegVar("desc", get_desc, set_desc);
		L.RegVar("ratio", get_ratio, set_ratio);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNTGBattleUnitController_UnitBuff(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NTGBattleUnitController.UnitBuff obj = new NTGBattleUnitController.UnitBuff();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NTGBattleUnitController.UnitBuff.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_icon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUnitController.UnitBuff obj = (NTGBattleUnitController.UnitBuff)o;
			string ret = obj.icon;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index icon on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_desc(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUnitController.UnitBuff obj = (NTGBattleUnitController.UnitBuff)o;
			string ret = obj.desc;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index desc on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ratio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUnitController.UnitBuff obj = (NTGBattleUnitController.UnitBuff)o;
			float ret = obj.ratio;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ratio on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_icon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUnitController.UnitBuff obj = (NTGBattleUnitController.UnitBuff)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.icon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index icon on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_desc(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUnitController.UnitBuff obj = (NTGBattleUnitController.UnitBuff)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.desc = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index desc on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ratio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUnitController.UnitBuff obj = (NTGBattleUnitController.UnitBuff)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.ratio = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ratio on a nil value" : e.Message);
		}
	}
}

