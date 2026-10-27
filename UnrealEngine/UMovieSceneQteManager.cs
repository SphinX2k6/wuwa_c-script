using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F3 RID: 9971
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteManager")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneQteManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024FBF RID: 151487 RVA: 0x0036B5F4 File Offset: 0x003697F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteManager._ClassPtr;
		}

		// Token: 0x06024FC0 RID: 151488 RVA: 0x0036B600 File Offset: 0x00369800
		public UMovieSceneQteManager() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024FC1 RID: 151489 RVA: 0x0036B628 File Offset: 0x00369828
		public UMovieSceneQteManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008ED2 RID: 36562
		// (get) Token: 0x06024FC2 RID: 151490 RVA: 0x0036B65C File Offset: 0x0036985C
		// (set) Token: 0x06024FC3 RID: 151491 RVA: 0x0036B695 File Offset: 0x00369895
		public FOnQteAnimEnd OnQteAnimEnd
		{
			get
			{
				base.FastCheckIsValid();
				FOnQteAnimEnd result;
				if ((result = this._OnQteAnimEnd) == null)
				{
					result = (this._OnQteAnimEnd = new FOnQteAnimEnd(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_OnQteAnimEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_OnQteAnimEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008ED3 RID: 36563
		// (get) Token: 0x06024FC4 RID: 151492 RVA: 0x0036B6B8 File Offset: 0x003698B8
		// (set) Token: 0x06024FC5 RID: 151493 RVA: 0x0036B6F1 File Offset: 0x003698F1
		public FOnQteStart OnQteStart
		{
			get
			{
				base.FastCheckIsValid();
				FOnQteStart result;
				if ((result = this._OnQteStart) == null)
				{
					result = (this._OnQteStart = new FOnQteStart(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_OnQteStart, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_OnQteStart, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008ED4 RID: 36564
		// (get) Token: 0x06024FC6 RID: 151494 RVA: 0x0036B714 File Offset: 0x00369914
		// (set) Token: 0x06024FC7 RID: 151495 RVA: 0x0036B74D File Offset: 0x0036994D
		public TMap<UAnimInstance, FMovieSceneQteAnimParams> AnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UAnimInstance, FMovieSceneQteAnimParams> result;
				if ((result = this._AnimMap) == null)
				{
					result = (this._AnimMap = new TMap<UAnimInstance, FMovieSceneQteAnimParams>(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_AnimMap, this));
				}
				return result;
			}
			set
			{
				this.AnimMap.CopyAssign(value);
			}
		}

		// Token: 0x17008ED5 RID: 36565
		// (get) Token: 0x06024FC8 RID: 151496 RVA: 0x0036B75B File Offset: 0x0036995B
		// (set) Token: 0x06024FC9 RID: 151497 RVA: 0x0036B76F File Offset: 0x0036996F
		[Nullable(2)]
		public unsafe ALevelSequenceActor QteSeqActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneQteManager.__PropertyOffset_QteSeqActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneQteManager.__PropertyOffset_QteSeqActor, value);
			}
		}

		// Token: 0x17008ED6 RID: 36566
		// (get) Token: 0x06024FCA RID: 151498 RVA: 0x0036B784 File Offset: 0x00369984
		// (set) Token: 0x06024FCB RID: 151499 RVA: 0x0036B7BD File Offset: 0x003699BD
		public TMap<UAnimMontage, UAnimInstance> MontageToAnimInstance
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UAnimMontage, UAnimInstance> result;
				if ((result = this._MontageToAnimInstance) == null)
				{
					result = (this._MontageToAnimInstance = new TMap<UAnimMontage, UAnimInstance>(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_MontageToAnimInstance, this));
				}
				return result;
			}
			set
			{
				this.MontageToAnimInstance.CopyAssign(value);
			}
		}

		// Token: 0x06024FCC RID: 151500 RVA: 0x0036B7CB File Offset: 0x003699CB
		public void UpdateQte(int Id, bool bProgress, float ProgressPercentage)
		{
			UMovieSceneQteManager.__UpdateQte_Internal(base.NativePtr, Id, bProgress, ProgressPercentage);
		}

		// Token: 0x06024FCD RID: 151501 RVA: 0x0036B7DB File Offset: 0x003699DB
		public void OnSequencePaused()
		{
			UMovieSceneQteManager.__OnSequencePaused_Internal(base.NativePtr);
		}

		// Token: 0x06024FCE RID: 151502 RVA: 0x0036B7E8 File Offset: 0x003699E8
		[NullableContext(2)]
		public void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
		{
			UMovieSceneQteManager.__OnMontageBlendingOut_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x06024FCF RID: 151503 RVA: 0x0036B806 File Offset: 0x00369A06
		public void FinishQte(int Id)
		{
			UMovieSceneQteManager.__FinishQte_Internal(base.NativePtr, Id);
		}

		// Token: 0x06024FD0 RID: 151504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateQte_Internal(IntPtr @this, int Id, bool bProgress, float ProgressPercentage);

		// Token: 0x06024FD1 RID: 151505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSequencePaused_Internal(IntPtr @this);

		// Token: 0x06024FD2 RID: 151506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageBlendingOut_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x06024FD3 RID: 151507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishQte_Internal(IntPtr @this, int Id);

		// Token: 0x06024FD4 RID: 151508 RVA: 0x0036B814 File Offset: 0x00369A14
		static UMovieSceneQteManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteManager");
		}

		// Token: 0x06024FD5 RID: 151509 RVA: 0x0036B822 File Offset: 0x00369A22
		protected UMovieSceneQteManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013EE3 RID: 81635
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteManager";

		// Token: 0x04013EE4 RID: 81636
		private static IntPtr _ClassPtr;

		// Token: 0x04013EE5 RID: 81637
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013EE6 RID: 81638
		internal static int __PropertyOffset_OnQteAnimEnd;

		// Token: 0x04013EE7 RID: 81639
		[Nullable(2)]
		private FOnQteAnimEnd _OnQteAnimEnd;

		// Token: 0x04013EE8 RID: 81640
		internal static int __PropertyOffset_OnQteStart;

		// Token: 0x04013EE9 RID: 81641
		[Nullable(2)]
		private FOnQteStart _OnQteStart;

		// Token: 0x04013EEA RID: 81642
		internal static int __PropertyOffset_AnimMap;

		// Token: 0x04013EEB RID: 81643
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UAnimInstance, FMovieSceneQteAnimParams> _AnimMap;

		// Token: 0x04013EEC RID: 81644
		internal static int __PropertyOffset_QteSeqActor;

		// Token: 0x04013EED RID: 81645
		internal static int __PropertyOffset_MontageToAnimInstance;

		// Token: 0x04013EEE RID: 81646
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UAnimMontage, UAnimInstance> _MontageToAnimInstance;
	}
}
