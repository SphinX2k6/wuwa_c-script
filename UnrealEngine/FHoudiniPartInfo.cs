using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014FD RID: 5373
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniPartInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FHoudiniPartInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013794 RID: 79764 RVA: 0x001CA1C2 File Offset: 0x001C83C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniPartInfo._ScriptStructPtr != 0) ? FHoudiniPartInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniPartInfo", ref FHoudiniPartInfo._ScriptStructPtr);
		}

		// Token: 0x06013795 RID: 79765 RVA: 0x001CA1E6 File Offset: 0x001C83E6
		public FHoudiniPartInfo()
		{
		}

		// Token: 0x06013796 RID: 79766 RVA: 0x001CA1EE File Offset: 0x001C83EE
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniPartInfo.StaticStruct();
		}

		// Token: 0x06013797 RID: 79767 RVA: 0x001CA1FA File Offset: 0x001C83FA
		[NullableContext(2)]
		public FHoudiniPartInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013798 RID: 79768 RVA: 0x001CA204 File Offset: 0x001C8404
		public FHoudiniPartInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013799 RID: 79769 RVA: 0x001CA20F File Offset: 0x001C840F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniPartInfo(Pointer, false, true);
		}

		// Token: 0x0601379A RID: 79770 RVA: 0x001CA219 File Offset: 0x001C8419
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniPartInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A872 RID: 43122
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniPartInfo";

		// Token: 0x0400A873 RID: 43123
		private static IntPtr _ScriptStructPtr;
	}
}
