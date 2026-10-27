using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A60 RID: 10848
	[UnrealObjectPath("/Script/WebBrowser.WebJSFunction")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FWebJSFunction : FWebJSCallbackBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280A8 RID: 164008 RVA: 0x003CF2B2 File Offset: 0x003CD4B2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWebJSFunction._ScriptStructPtr != 0) ? FWebJSFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WebBrowser.WebJSFunction", ref FWebJSFunction._ScriptStructPtr);
		}

		// Token: 0x060280A9 RID: 164009 RVA: 0x003CF2D6 File Offset: 0x003CD4D6
		public FWebJSFunction()
		{
		}

		// Token: 0x060280AA RID: 164010 RVA: 0x003CF2DE File Offset: 0x003CD4DE
		protected override IntPtr GetUStructPtr()
		{
			return FWebJSFunction.StaticStruct();
		}

		// Token: 0x060280AB RID: 164011 RVA: 0x003CF2EA File Offset: 0x003CD4EA
		[NullableContext(2)]
		public FWebJSFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280AC RID: 164012 RVA: 0x003CF2F4 File Offset: 0x003CD4F4
		public FWebJSFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280AD RID: 164013 RVA: 0x003CF2FF File Offset: 0x003CD4FF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWebJSFunction(Pointer, false, true);
		}

		// Token: 0x060280AE RID: 164014 RVA: 0x003CF309 File Offset: 0x003CD509
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWebJSFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04015F6F RID: 89967
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WebBrowser.WebJSFunction";

		// Token: 0x04015F70 RID: 89968
		private static IntPtr _ScriptStructPtr;
	}
}
