using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001210 RID: 4624
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TViewTarget")]
	[UnrealStructLayout(2768, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2768)]
	public class FTViewTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601106C RID: 69740 RVA: 0x0018FABD File Offset: 0x0018DCBD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTViewTarget._ScriptStructPtr != 0) ? FTViewTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TViewTarget", ref FTViewTarget._ScriptStructPtr);
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x0601106D RID: 69741 RVA: 0x0018FAE1 File Offset: 0x0018DCE1
		// (set) Token: 0x0601106E RID: 69742 RVA: 0x0018FAF5 File Offset: 0x0018DCF5
		public unsafe AActor Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FTViewTarget.__PropertyOffset_Target);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTViewTarget.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x0601106F RID: 69743 RVA: 0x0018FB0C File Offset: 0x0018DD0C
		// (set) Token: 0x06011070 RID: 69744 RVA: 0x0018FB4F File Offset: 0x0018DD4F
		[Nullable(1)]
		public FMinimalViewInfo POV
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMinimalViewInfo result;
				if ((result = this._POV) == null)
				{
					result = (this._POV = new FMinimalViewInfo(base.NativePtr + (IntPtr)FTViewTarget.__PropertyOffset_POV, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMinimalViewInfo.StaticStruct(), base.NativePtr + (IntPtr)FTViewTarget.__PropertyOffset_POV, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x06011071 RID: 69745 RVA: 0x0018FB70 File Offset: 0x0018DD70
		// (set) Token: 0x06011072 RID: 69746 RVA: 0x0018FB84 File Offset: 0x0018DD84
		public unsafe APlayerState PlayerState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + FTViewTarget.__PropertyOffset_PlayerState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTViewTarget.__PropertyOffset_PlayerState, value);
			}
		}

		// Token: 0x06011073 RID: 69747 RVA: 0x0018FB99 File Offset: 0x0018DD99
		public FTViewTarget()
		{
		}

		// Token: 0x06011074 RID: 69748 RVA: 0x0018FBA1 File Offset: 0x0018DDA1
		[NullableContext(1)]
		public FTViewTarget(AActor Target, FMinimalViewInfo POV, APlayerState PlayerState)
		{
			this.Target = Target;
			this.POV = POV;
			this.PlayerState = PlayerState;
		}

		// Token: 0x06011075 RID: 69749 RVA: 0x0018FBBE File Offset: 0x0018DDBE
		protected override IntPtr GetUStructPtr()
		{
			return FTViewTarget.StaticStruct();
		}

		// Token: 0x06011076 RID: 69750 RVA: 0x0018FBCA File Offset: 0x0018DDCA
		public FTViewTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011077 RID: 69751 RVA: 0x0018FBD4 File Offset: 0x0018DDD4
		public FTViewTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011078 RID: 69752 RVA: 0x0018FBDF File Offset: 0x0018DDDF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTViewTarget(Pointer, false, true);
		}

		// Token: 0x06011079 RID: 69753 RVA: 0x0018FBE9 File Offset: 0x0018DDE9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTViewTarget(Pointer, MemoryOwner);
		}

		// Token: 0x040091D2 RID: 37330
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TViewTarget";

		// Token: 0x040091D3 RID: 37331
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091D4 RID: 37332
		internal static int __PropertyOffset_Target;

		// Token: 0x040091D5 RID: 37333
		internal static int __PropertyOffset_POV;

		// Token: 0x040091D6 RID: 37334
		private FMinimalViewInfo _POV;

		// Token: 0x040091D7 RID: 37335
		internal static int __PropertyOffset_PlayerState;
	}
}
