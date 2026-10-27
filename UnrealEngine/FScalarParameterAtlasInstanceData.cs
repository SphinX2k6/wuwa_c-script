using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010CD RID: 4301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ScalarParameterAtlasInstanceData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FScalarParameterAtlasInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F567 RID: 62823 RVA: 0x0016BB25 File Offset: 0x00169D25
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScalarParameterAtlasInstanceData._ScriptStructPtr != 0) ? FScalarParameterAtlasInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ScalarParameterAtlasInstanceData", ref FScalarParameterAtlasInstanceData._ScriptStructPtr);
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600F568 RID: 62824 RVA: 0x0016BB49 File Offset: 0x00169D49
		// (set) Token: 0x0600F569 RID: 62825 RVA: 0x0016BB59 File Offset: 0x00169D59
		public unsafe bool bIsUsedAsAtlasPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScalarParameterAtlasInstanceData.__PropertyOffset_bIsUsedAsAtlasPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScalarParameterAtlasInstanceData.__PropertyOffset_bIsUsedAsAtlasPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0600F56A RID: 62826 RVA: 0x0016BB6A File Offset: 0x00169D6A
		// (set) Token: 0x0600F56B RID: 62827 RVA: 0x0016BB89 File Offset: 0x00169D89
		public TSoftObjectPtr<UCurveLinearColor> Curve
		{
			get
			{
				return new TSoftObjectPtr<UCurveLinearColor>(base.NativePtr + (IntPtr)FScalarParameterAtlasInstanceData.__PropertyOffset_Curve, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FScalarParameterAtlasInstanceData.__PropertyOffset_Curve, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0600F56C RID: 62828 RVA: 0x0016BBAE File Offset: 0x00169DAE
		// (set) Token: 0x0600F56D RID: 62829 RVA: 0x0016BBCD File Offset: 0x00169DCD
		public TSoftObjectPtr<UCurveLinearColorAtlas> Atlas
		{
			get
			{
				return new TSoftObjectPtr<UCurveLinearColorAtlas>(base.NativePtr + (IntPtr)FScalarParameterAtlasInstanceData.__PropertyOffset_Atlas, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FScalarParameterAtlasInstanceData.__PropertyOffset_Atlas, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0600F56E RID: 62830 RVA: 0x0016BBF2 File Offset: 0x00169DF2
		public FScalarParameterAtlasInstanceData()
		{
		}

		// Token: 0x0600F56F RID: 62831 RVA: 0x0016BBFA File Offset: 0x00169DFA
		public FScalarParameterAtlasInstanceData(bool bIsUsedAsAtlasPosition, TSoftObjectPtr<UCurveLinearColor> Curve, TSoftObjectPtr<UCurveLinearColorAtlas> Atlas)
		{
			this.bIsUsedAsAtlasPosition = bIsUsedAsAtlasPosition;
			this.Curve = Curve;
			this.Atlas = Atlas;
		}

		// Token: 0x0600F570 RID: 62832 RVA: 0x0016BC17 File Offset: 0x00169E17
		protected override IntPtr GetUStructPtr()
		{
			return FScalarParameterAtlasInstanceData.StaticStruct();
		}

		// Token: 0x0600F571 RID: 62833 RVA: 0x0016BC23 File Offset: 0x00169E23
		[NullableContext(2)]
		public FScalarParameterAtlasInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F572 RID: 62834 RVA: 0x0016BC2D File Offset: 0x00169E2D
		public FScalarParameterAtlasInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F573 RID: 62835 RVA: 0x0016BC38 File Offset: 0x00169E38
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScalarParameterAtlasInstanceData(Pointer, false, true);
		}

		// Token: 0x0600F574 RID: 62836 RVA: 0x0016BC42 File Offset: 0x00169E42
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScalarParameterAtlasInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040084F5 RID: 34037
		public const string __ObjectPath = "/Script/Engine.ScalarParameterAtlasInstanceData";

		// Token: 0x040084F6 RID: 34038
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040084F7 RID: 34039
		internal static int __PropertyOffset_bIsUsedAsAtlasPosition;

		// Token: 0x040084F8 RID: 34040
		internal static int __PropertyOffset_Curve;

		// Token: 0x040084F9 RID: 34041
		internal static int __PropertyOffset_Atlas;
	}
}
