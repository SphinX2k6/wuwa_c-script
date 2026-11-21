using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002E0 RID: 736
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BoneFeedbackAnimHitInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBoneFeedbackAnimHitInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F99 RID: 20377 RVA: 0x0006F746 File Offset: 0x0006D946
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFeedbackAnimHitInfo._ScriptStructPtr != 0) ? FBoneFeedbackAnimHitInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BoneFeedbackAnimHitInfo", ref FBoneFeedbackAnimHitInfo._ScriptStructPtr);
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x0006F76C File Offset: 0x0006D96C
		// (set) Token: 0x06004F9B RID: 20379 RVA: 0x0006F7AF File Offset: 0x0006D9AF
		public TArray<FName> FirstHitBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FirstHitBoneNames) == null)
				{
					result = (this._FirstHitBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_FirstHitBoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FirstHitBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x0006F7C0 File Offset: 0x0006D9C0
		// (set) Token: 0x06004F9D RID: 20381 RVA: 0x0006F803 File Offset: 0x0006DA03
		public TArray<FName> HitBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._HitBoneNames) == null)
				{
					result = (this._HitBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitBoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HitBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x0006F811 File Offset: 0x0006DA11
		// (set) Token: 0x06004F9F RID: 20383 RVA: 0x0006F825 File Offset: 0x0006DA25
		public unsafe FVectorDouble AttackPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_AttackPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_AttackPoint) = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x0006F83A File Offset: 0x0006DA3A
		// (set) Token: 0x06004FA1 RID: 20385 RVA: 0x0006F84E File Offset: 0x0006DA4E
		public unsafe FVector HitVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitVector) = value;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x0006F863 File Offset: 0x0006DA63
		// (set) Token: 0x06004FA3 RID: 20387 RVA: 0x0006F873 File Offset: 0x0006DA73
		public unsafe int StateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_StateType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_StateType) = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0006F884 File Offset: 0x0006DA84
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x0006F894 File Offset: 0x0006DA94
		public unsafe int HitType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitType) = value;
			}
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x0006F8A5 File Offset: 0x0006DAA5
		public FBoneFeedbackAnimHitInfo()
		{
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x0006F8AD File Offset: 0x0006DAAD
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFeedbackAnimHitInfo.StaticStruct();
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x0006F8B9 File Offset: 0x0006DAB9
		[NullableContext(2)]
		public FBoneFeedbackAnimHitInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x0006F8C3 File Offset: 0x0006DAC3
		public FBoneFeedbackAnimHitInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x0006F8CE File Offset: 0x0006DACE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFeedbackAnimHitInfo(Pointer, false, true);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x0006F8D8 File Offset: 0x0006DAD8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFeedbackAnimHitInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04001FF5 RID: 8181
		public const string __ObjectPath = "/Script/KuroAnim.BoneFeedbackAnimHitInfo";

		// Token: 0x04001FF6 RID: 8182
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FF7 RID: 8183
		internal static int __PropertyOffset_FirstHitBoneNames;

		// Token: 0x04001FF8 RID: 8184
		[Nullable(2)]
		private TArray<FName> _FirstHitBoneNames;

		// Token: 0x04001FF9 RID: 8185
		internal static int __PropertyOffset_HitBoneNames;

		// Token: 0x04001FFA RID: 8186
		[Nullable(2)]
		private TArray<FName> _HitBoneNames;

		// Token: 0x04001FFB RID: 8187
		internal static int __PropertyOffset_AttackPoint;

		// Token: 0x04001FFC RID: 8188
		internal static int __PropertyOffset_HitVector;

		// Token: 0x04001FFD RID: 8189
		internal static int __PropertyOffset_StateType;

		// Token: 0x04001FFE RID: 8190
		internal static int __PropertyOffset_HitType;
	}
}
