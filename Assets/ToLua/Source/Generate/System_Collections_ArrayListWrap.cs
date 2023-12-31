﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Collections_ArrayListWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Collections.ArrayList), typeof(System.Object));
		L.RegFunction("get_Item", get_Item);
		L.RegFunction("set_Item", set_Item);
		L.RegFunction("Add", Add);
		L.RegFunction("Clear", Clear);
		L.RegFunction("Contains", Contains);
		L.RegFunction("IndexOf", IndexOf);
		L.RegFunction("LastIndexOf", LastIndexOf);
		L.RegFunction("Insert", Insert);
		L.RegFunction("InsertRange", InsertRange);
		L.RegFunction("Remove", Remove);
		L.RegFunction("RemoveAt", RemoveAt);
		L.RegFunction("RemoveRange", RemoveRange);
		L.RegFunction("Reverse", Reverse);
		L.RegFunction("CopyTo", CopyTo);
		L.RegFunction("GetEnumerator", GetEnumerator);
		L.RegFunction("AddRange", AddRange);
		L.RegFunction("BinarySearch", BinarySearch);
		L.RegFunction("GetRange", GetRange);
		L.RegFunction("SetRange", SetRange);
		L.RegFunction("TrimToSize", TrimToSize);
		L.RegFunction("Sort", Sort);
		L.RegFunction("ToArray", ToArray);
		L.RegFunction("Clone", Clone);
		L.RegFunction("Adapter", Adapter);
		L.RegFunction("Synchronized", Synchronized);
		L.RegFunction("ReadOnly", ReadOnly);
		L.RegFunction("FixedSize", FixedSize);
		L.RegFunction("Repeat", Repeat);
		L.RegFunction("New", _CreateSystem_Collections_ArrayList);
		L.RegVar("this", _this, null);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Count", get_Count, null);
		L.RegVar("Capacity", get_Capacity, set_Capacity);
		L.RegVar("IsFixedSize", get_IsFixedSize, null);
		L.RegVar("IsReadOnly", get_IsReadOnly, null);
		L.RegVar("IsSynchronized", get_IsSynchronized, null);
		L.RegVar("SyncRoot", get_SyncRoot, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSystem_Collections_ArrayList(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				System.Collections.ArrayList obj = new System.Collections.ArrayList();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(int)))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				System.Collections.ArrayList obj = new System.Collections.ArrayList(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ICollection)))
			{
				System.Collections.ICollection arg0 = (System.Collections.ICollection)ToLua.CheckObject(L, 1, typeof(System.Collections.ICollection));
				System.Collections.ArrayList obj = new System.Collections.ArrayList(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: System.Collections.ArrayList.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object o = obj[arg0];
			ToLua.Push(L, o);
			return 1;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj[arg0] = arg1;
			return 0;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object o = obj[arg0];
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj[arg0] = arg1;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			object arg0 = ToLua.ToVarObject(L, 2);
			int o = obj.Add(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			obj.Clear();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj.Contains(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IndexOf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int o = obj.IndexOf(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int o = obj.IndexOf(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object), typeof(int), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int o = obj.IndexOf(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.IndexOf");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LastIndexOf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int o = obj.LastIndexOf(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int o = obj.LastIndexOf(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object), typeof(int), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int o = obj.LastIndexOf(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.LastIndexOf");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Insert(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj.Insert(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InsertRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.ICollection arg1 = (System.Collections.ICollection)ToLua.CheckObject(L, 3, typeof(System.Collections.ICollection));
			obj.InsertRange(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.Remove(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.RemoveAt(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.RemoveRange(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reverse(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				obj.Reverse();
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(int), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.Reverse(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.Reverse");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyTo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(System.Array)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Array arg0 = (System.Array)ToLua.ToObject(L, 2);
				obj.CopyTo(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(System.Array), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Array arg0 = (System.Array)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.CopyTo(arg0, arg1);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(int), typeof(System.Array), typeof(int), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				System.Array arg1 = (System.Array)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				obj.CopyTo(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.CopyTo");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Collections.IEnumerator o = obj.GetEnumerator();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(int), typeof(int)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				System.Collections.IEnumerator o = obj.GetEnumerator(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.GetEnumerator");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			System.Collections.ICollection arg0 = (System.Collections.ICollection)ToLua.CheckObject(L, 2, typeof(System.Collections.ICollection));
			obj.AddRange(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BinarySearch(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int o = obj.BinarySearch(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(object), typeof(System.Collections.IComparer)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				System.Collections.IComparer arg1 = (System.Collections.IComparer)ToLua.ToObject(L, 3);
				int o = obj.BinarySearch(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(int), typeof(int), typeof(object), typeof(System.Collections.IComparer)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				object arg2 = ToLua.ToVarObject(L, 4);
				System.Collections.IComparer arg3 = (System.Collections.IComparer)ToLua.ToObject(L, 5);
				int o = obj.BinarySearch(arg0, arg1, arg2, arg3);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.BinarySearch");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			System.Collections.ArrayList o = obj.GetRange(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.ICollection arg1 = (System.Collections.ICollection)ToLua.CheckObject(L, 3, typeof(System.Collections.ICollection));
			obj.SetRange(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrimToSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			obj.TrimToSize();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Sort(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				obj.Sort();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(System.Collections.IComparer)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Collections.IComparer arg0 = (System.Collections.IComparer)ToLua.ToObject(L, 2);
				obj.Sort(arg0);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(int), typeof(int), typeof(System.Collections.IComparer)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				System.Collections.IComparer arg2 = (System.Collections.IComparer)ToLua.ToObject(L, 4);
				obj.Sort(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.Sort");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToArray(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				object[] o = obj.ToArray();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList), typeof(System.Type)))
			{
				System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				System.Array o = obj.ToArray(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.ToArray");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)ToLua.CheckObject(L, 1, typeof(System.Collections.ArrayList));
			object o = obj.Clone();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Adapter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.IList arg0 = (System.Collections.IList)ToLua.CheckObject(L, 1, typeof(System.Collections.IList));
			System.Collections.ArrayList o = System.Collections.ArrayList.Adapter(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Synchronized(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.IList)))
			{
				System.Collections.IList arg0 = (System.Collections.IList)ToLua.ToObject(L, 1);
				System.Collections.IList o = System.Collections.ArrayList.Synchronized(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList arg0 = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Collections.ArrayList o = System.Collections.ArrayList.Synchronized(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.Synchronized");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadOnly(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.IList)))
			{
				System.Collections.IList arg0 = (System.Collections.IList)ToLua.ToObject(L, 1);
				System.Collections.IList o = System.Collections.ArrayList.ReadOnly(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList arg0 = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Collections.ArrayList o = System.Collections.ArrayList.ReadOnly(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.ReadOnly");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FixedSize(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.IList)))
			{
				System.Collections.IList arg0 = (System.Collections.IList)ToLua.ToObject(L, 1);
				System.Collections.IList o = System.Collections.ArrayList.FixedSize(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.ArrayList)))
			{
				System.Collections.ArrayList arg0 = (System.Collections.ArrayList)ToLua.ToObject(L, 1);
				System.Collections.ArrayList o = System.Collections.ArrayList.FixedSize(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Collections.ArrayList.FixedSize");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Repeat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object arg0 = ToLua.ToVarObject(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.ArrayList o = System.Collections.ArrayList.Repeat(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
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
	static int get_Count(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			int ret = obj.Count;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Count on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Capacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			int ret = obj.Capacity;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Capacity on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsFixedSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			bool ret = obj.IsFixedSize;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsFixedSize on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsReadOnly(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			bool ret = obj.IsReadOnly;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsReadOnly on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSynchronized(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			bool ret = obj.IsSynchronized;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsSynchronized on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SyncRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			object ret = obj.SyncRoot;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index SyncRoot on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Capacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.ArrayList obj = (System.Collections.ArrayList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Capacity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Capacity on a nil value" : e.Message);
		}
	}
}

