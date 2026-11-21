using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000584 RID: 1412
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SceneMovement")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UKSC_SceneMovement : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600801E RID: 32798 RVA: 0x000BD5F7 File Offset: 0x000BB7F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_SceneMovement._ClassPtr;
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x000BD604 File Offset: 0x000BB804
		public UKSC_SceneMovement() : this(BuiltinUtils.AllocNativeUObject(UKSC_SceneMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x000BD62C File Offset: 0x000BB82C
		public UKSC_SceneMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_SceneMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06008021 RID: 32801 RVA: 0x000BD660 File Offset: 0x000BB860
		// (set) Token: 0x06008022 RID: 32802 RVA: 0x000BD699 File Offset: 0x000BB899
		public TMap<UKSC_DA_SceneSegmentContainer, int> LoadedSceneSegmentDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_SceneSegmentContainer, int> result;
				if ((result = this._LoadedSceneSegmentDa) == null)
				{
					result = (this._LoadedSceneSegmentDa = new TMap<UKSC_DA_SceneSegmentContainer, int>(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_LoadedSceneSegmentDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedSceneSegmentDa.CopyAssign(value);
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06008023 RID: 32803 RVA: 0x000BD6A7 File Offset: 0x000BB8A7
		// (set) Token: 0x06008024 RID: 32804 RVA: 0x000BD6BB File Offset: 0x000BB8BB
		public unsafe FVector MovementDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementDirection) = value;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x000BD6D0 File Offset: 0x000BB8D0
		// (set) Token: 0x06008026 RID: 32806 RVA: 0x000BD6E4 File Offset: 0x000BB8E4
		public unsafe FVector MovementRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementRight) = value;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x000BD6F9 File Offset: 0x000BB8F9
		// (set) Token: 0x06008028 RID: 32808 RVA: 0x000BD70D File Offset: 0x000BB90D
		public unsafe FVector MovementUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementUp) = value;
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06008029 RID: 32809 RVA: 0x000BD722 File Offset: 0x000BB922
		// (set) Token: 0x0600802A RID: 32810 RVA: 0x000BD736 File Offset: 0x000BB936
		public unsafe FVector MovementTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementTarget) = value;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x0600802B RID: 32811 RVA: 0x000BD74B File Offset: 0x000BB94B
		// (set) Token: 0x0600802C RID: 32812 RVA: 0x000BD75F File Offset: 0x000BB95F
		public unsafe FRotator SegmentRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SegmentRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SegmentRotation) = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600802D RID: 32813 RVA: 0x000BD774 File Offset: 0x000BB974
		// (set) Token: 0x0600802E RID: 32814 RVA: 0x000BD784 File Offset: 0x000BB984
		public unsafe float SceneSegmentLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentLength) = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600802F RID: 32815 RVA: 0x000BD795 File Offset: 0x000BB995
		// (set) Token: 0x06008030 RID: 32816 RVA: 0x000BD7A5 File Offset: 0x000BB9A5
		public unsafe int SceneSegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentCount) = value;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06008031 RID: 32817 RVA: 0x000BD7B6 File Offset: 0x000BB9B6
		// (set) Token: 0x06008032 RID: 32818 RVA: 0x000BD7C6 File Offset: 0x000BB9C6
		public unsafe int SceneSegmentGenerateCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentGenerateCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentGenerateCount) = value;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06008033 RID: 32819 RVA: 0x000BD7D7 File Offset: 0x000BB9D7
		// (set) Token: 0x06008034 RID: 32820 RVA: 0x000BD7E7 File Offset: 0x000BB9E7
		public unsafe float MoveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistance) = value;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x000BD7F8 File Offset: 0x000BB9F8
		// (set) Token: 0x06008036 RID: 32822 RVA: 0x000BD831 File Offset: 0x000BBA31
		public FOnSceneSegmentFinish OnSceneSegmentFinish
		{
			get
			{
				base.FastCheckIsValid();
				FOnSceneSegmentFinish result;
				if ((result = this._OnSceneSegmentFinish) == null)
				{
					result = (this._OnSceneSegmentFinish = new FOnSceneSegmentFinish(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneSegmentFinish, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneSegmentFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x000BD854 File Offset: 0x000BBA54
		// (set) Token: 0x06008038 RID: 32824 RVA: 0x000BD88D File Offset: 0x000BBA8D
		public FOnSceneMoveThreshold OnSceneMoveThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FOnSceneMoveThreshold result;
				if ((result = this._OnSceneMoveThreshold) == null)
				{
					result = (this._OnSceneMoveThreshold = new FOnSceneMoveThreshold(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneMoveThreshold, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneMoveThreshold, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x000BD8AE File Offset: 0x000BBAAE
		// (set) Token: 0x0600803A RID: 32826 RVA: 0x000BD8BE File Offset: 0x000BBABE
		public unsafe float MoveDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistanceThreshold) = value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x0600803B RID: 32827 RVA: 0x000BD8CF File Offset: 0x000BBACF
		// (set) Token: 0x0600803C RID: 32828 RVA: 0x000BD8DF File Offset: 0x000BBADF
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600803D RID: 32829 RVA: 0x000BD8F0 File Offset: 0x000BBAF0
		// (set) Token: 0x0600803E RID: 32830 RVA: 0x000BD929 File Offset: 0x000BBB29
		public TArray<AKSC_SceneSegment> SceneSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_SceneSegment> result;
				if ((result = this._SceneSegments) == null)
				{
					result = (this._SceneSegments = new TArray<AKSC_SceneSegment>(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegments, this));
				}
				return result;
			}
			set
			{
				this.SceneSegments.CopyAssign(value);
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600803F RID: 32831 RVA: 0x000BD937 File Offset: 0x000BBB37
		// (set) Token: 0x06008040 RID: 32832 RVA: 0x000BD94B File Offset: 0x000BBB4B
		[Nullable(2)]
		public unsafe UKSC_DA_SceneSegmentContainer SceneSegmentContainer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SceneSegmentContainer>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SceneMovement.__PropertyOffset_SceneSegmentContainer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SceneMovement.__PropertyOffset_SceneSegmentContainer, value);
			}
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x000BD960 File Offset: 0x000BBB60
		public void SetSegmentRotation(in FRotator NewSegmentRotation)
		{
			UKSC_SceneMovement.__SetSegmentRotation_Internal(base.NativePtr, NewSegmentRotation);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x000BD96E File Offset: 0x000BBB6E
		[NullableContext(2)]
		public void SetSceneSegment(UKSC_DA_SceneSegmentContainer NewSceneSegment, int GenerateCount = -1)
		{
			UKSC_SceneMovement.__SetSceneSegment_Internal(base.NativePtr, (NewSceneSegment != null) ? NewSceneSegment.NativePtr : IntPtr.Zero, GenerateCount);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x000BD98C File Offset: 0x000BBB8C
		public void SetMovementDirection(in FVector NewMovementDirection)
		{
			UKSC_SceneMovement.__SetMovementDirection_Internal(base.NativePtr, NewMovementDirection);
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x000BD99A File Offset: 0x000BBB9A
		public void D_SetMovementTarget(in FVectorDouble NewMovementTarget)
		{
			UKSC_SceneMovement.__D_SetMovementTarget_Internal(base.NativePtr, NewMovementTarget);
		}

		// Token: 0x06008045 RID: 32837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSegmentRotation_Internal(IntPtr @this, in FRotator NewSegmentRotation);

		// Token: 0x06008046 RID: 32838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneSegment_Internal(IntPtr @this, IntPtr NewSceneSegment, int GenerateCount);

		// Token: 0x06008047 RID: 32839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMovementDirection_Internal(IntPtr @this, in FVector NewMovementDirection);

		// Token: 0x06008048 RID: 32840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetMovementTarget_Internal(IntPtr @this, in FVectorDouble NewMovementTarget);

		// Token: 0x06008049 RID: 32841 RVA: 0x000BD9A8 File Offset: 0x000BBBA8
		static UKSC_SceneMovement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SceneMovement");
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x000BD9B6 File Offset: 0x000BBBB6
		protected UKSC_SceneMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037ED RID: 14317
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneMovement";

		// Token: 0x040037EE RID: 14318
		private static IntPtr _ClassPtr;

		// Token: 0x040037EF RID: 14319
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037F0 RID: 14320
		public static IntPtr __OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040037F1 RID: 14321
		public static IntPtr __OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040037F2 RID: 14322
		internal static int __PropertyOffset_LoadedSceneSegmentDa;

		// Token: 0x040037F3 RID: 14323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_SceneSegmentContainer, int> _LoadedSceneSegmentDa;

		// Token: 0x040037F4 RID: 14324
		internal static int __PropertyOffset_MovementDirection;

		// Token: 0x040037F5 RID: 14325
		internal static int __PropertyOffset_MovementRight;

		// Token: 0x040037F6 RID: 14326
		internal static int __PropertyOffset_MovementUp;

		// Token: 0x040037F7 RID: 14327
		internal static int __PropertyOffset_MovementTarget;

		// Token: 0x040037F8 RID: 14328
		internal static int __PropertyOffset_SegmentRotation;

		// Token: 0x040037F9 RID: 14329
		internal static int __PropertyOffset_SceneSegmentLength;

		// Token: 0x040037FA RID: 14330
		internal static int __PropertyOffset_SceneSegmentCount;

		// Token: 0x040037FB RID: 14331
		internal static int __PropertyOffset_SceneSegmentGenerateCount;

		// Token: 0x040037FC RID: 14332
		internal static int __PropertyOffset_MoveDistance;

		// Token: 0x040037FD RID: 14333
		internal static int __PropertyOffset_OnSceneSegmentFinish;

		// Token: 0x040037FE RID: 14334
		[Nullable(2)]
		private FOnSceneSegmentFinish _OnSceneSegmentFinish;

		// Token: 0x040037FF RID: 14335
		internal static int __PropertyOffset_OnSceneMoveThreshold;

		// Token: 0x04003800 RID: 14336
		[Nullable(2)]
		private FOnSceneMoveThreshold _OnSceneMoveThreshold;

		// Token: 0x04003801 RID: 14337
		internal static int __PropertyOffset_MoveDistanceThreshold;

		// Token: 0x04003802 RID: 14338
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x04003803 RID: 14339
		internal static int __PropertyOffset_SceneSegments;

		// Token: 0x04003804 RID: 14340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_SceneSegment> _SceneSegments;

		// Token: 0x04003805 RID: 14341
		internal static int __PropertyOffset_SceneSegmentContainer;
	}
}
