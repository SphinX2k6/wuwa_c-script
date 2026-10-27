using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A5F RID: 10847
	[UnrealObjectPath("/Script/WebBrowser.WebJSCallbackBase")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FWebJSCallbackBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280A1 RID: 164001 RVA: 0x003CF252 File Offset: 0x003CD452
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWebJSCallbackBase._ScriptStructPtr != 0) ? FWebJSCallbackBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WebBrowser.WebJSCallbackBase", ref FWebJSCallbackBase._ScriptStructPtr);
		}

		// Token: 0x060280A2 RID: 164002 RVA: 0x003CF276 File Offset: 0x003CD476
		public FWebJSCallbackBase()
		{
		}

		// Token: 0x060280A3 RID: 164003 RVA: 0x003CF27E File Offset: 0x003CD47E
		protected override IntPtr GetUStructPtr()
		{
			return FWebJSCallbackBase.StaticStruct();
		}

		// Token: 0x060280A4 RID: 164004 RVA: 0x003CF28A File Offset: 0x003CD48A
		[NullableContext(2)]
		public FWebJSCallbackBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280A5 RID: 164005 RVA: 0x003CF294 File Offset: 0x003CD494
		public FWebJSCallbackBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280A6 RID: 164006 RVA: 0x003CF29F File Offset: 0x003CD49F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWebJSCallbackBase(Pointer, false, true);
		}

		// Token: 0x060280A7 RID: 164007 RVA: 0x003CF2A9 File Offset: 0x003CD4A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWebJSCallbackBase(Pointer, MemoryOwner);
		}

		// Token: 0x04015F6D RID: 89965
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WebBrowser.WebJSCallbackBase";

		// Token: 0x04015F6E RID: 89966
		private static IntPtr _ScriptStructPtr;
	}
}
