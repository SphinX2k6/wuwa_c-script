using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A61 RID: 10849
	[UnrealObjectPath("/Script/WebBrowser.WebJSResponse")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FWebJSResponse : FWebJSCallbackBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280AF RID: 164015 RVA: 0x003CF312 File Offset: 0x003CD512
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWebJSResponse._ScriptStructPtr != 0) ? FWebJSResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WebBrowser.WebJSResponse", ref FWebJSResponse._ScriptStructPtr);
		}

		// Token: 0x060280B0 RID: 164016 RVA: 0x003CF336 File Offset: 0x003CD536
		public FWebJSResponse()
		{
		}

		// Token: 0x060280B1 RID: 164017 RVA: 0x003CF33E File Offset: 0x003CD53E
		protected override IntPtr GetUStructPtr()
		{
			return FWebJSResponse.StaticStruct();
		}

		// Token: 0x060280B2 RID: 164018 RVA: 0x003CF34A File Offset: 0x003CD54A
		[NullableContext(2)]
		public FWebJSResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280B3 RID: 164019 RVA: 0x003CF354 File Offset: 0x003CD554
		public FWebJSResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280B4 RID: 164020 RVA: 0x003CF35F File Offset: 0x003CD55F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWebJSResponse(Pointer, false, true);
		}

		// Token: 0x060280B5 RID: 164021 RVA: 0x003CF369 File Offset: 0x003CD569
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWebJSResponse(Pointer, MemoryOwner);
		}

		// Token: 0x04015F71 RID: 89969
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WebBrowser.WebJSResponse";

		// Token: 0x04015F72 RID: 89970
		private static IntPtr _ScriptStructPtr;
	}
}
