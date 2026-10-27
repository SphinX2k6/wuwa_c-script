using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200153B RID: 5435
	[UnrealObjectPath("/Script/InteractiveToolsFramework.BrushStampData")]
	[UnrealStructLayout(180, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 180)]
	public class FBrushStampData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013BC1 RID: 80833 RVA: 0x001CFB11 File Offset: 0x001CDD11
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBrushStampData._ScriptStructPtr != 0) ? FBrushStampData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InteractiveToolsFramework.BrushStampData", ref FBrushStampData._ScriptStructPtr);
		}

		// Token: 0x06013BC2 RID: 80834 RVA: 0x001CFB35 File Offset: 0x001CDD35
		public FBrushStampData()
		{
		}

		// Token: 0x06013BC3 RID: 80835 RVA: 0x001CFB3D File Offset: 0x001CDD3D
		protected override IntPtr GetUStructPtr()
		{
			return FBrushStampData.StaticStruct();
		}

		// Token: 0x06013BC4 RID: 80836 RVA: 0x001CFB49 File Offset: 0x001CDD49
		[NullableContext(2)]
		public FBrushStampData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013BC5 RID: 80837 RVA: 0x001CFB53 File Offset: 0x001CDD53
		public FBrushStampData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013BC6 RID: 80838 RVA: 0x001CFB5E File Offset: 0x001CDD5E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBrushStampData(Pointer, false, true);
		}

		// Token: 0x06013BC7 RID: 80839 RVA: 0x001CFB68 File Offset: 0x001CDD68
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBrushStampData(Pointer, MemoryOwner);
		}

		// Token: 0x0400AACC RID: 43724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.BrushStampData";

		// Token: 0x0400AACD RID: 43725
		private static IntPtr _ScriptStructPtr;
	}
}
