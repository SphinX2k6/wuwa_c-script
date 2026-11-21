using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CD RID: 1997
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteManager")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UMovieSceneQteManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AC68 RID: 44136 RVA: 0x000FE79D File Offset: 0x000FC99D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteManager._ClassPtr;
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x000FE7AC File Offset: 0x000FC9AC
		public UMovieSceneQteManager() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x000FE7D4 File Offset: 0x000FC9D4
		public UMovieSceneQteManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x0600AC6B RID: 44139 RVA: 0x000FE808 File Offset: 0x000FCA08
		// (set) Token: 0x0600AC6C RID: 44140 RVA: 0x000FE841 File Offset: 0x000FCA41
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

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600AC6D RID: 44141 RVA: 0x000FE864 File Offset: 0x000FCA64
		// (set) Token: 0x0600AC6E RID: 44142 RVA: 0x000FE89D File Offset: 0x000FCA9D
		public FOnQteSectionEnd OnQteSectionEnd
		{
			get
			{
				base.FastCheckIsValid();
				FOnQteSectionEnd result;
				if ((result = this._OnQteSectionEnd) == null)
				{
					result = (this._OnQteSectionEnd = new FOnQteSectionEnd(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_OnQteSectionEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_OnQteSectionEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x000FE8C0 File Offset: 0x000FCAC0
		// (set) Token: 0x0600AC70 RID: 44144 RVA: 0x000FE8F9 File Offset: 0x000FCAF9
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

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x0600AC71 RID: 44145 RVA: 0x000FE91A File Offset: 0x000FCB1A
		// (set) Token: 0x0600AC72 RID: 44146 RVA: 0x000FE92E File Offset: 0x000FCB2E
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

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600AC73 RID: 44147 RVA: 0x000FE944 File Offset: 0x000FCB44
		// (set) Token: 0x0600AC74 RID: 44148 RVA: 0x000FE97D File Offset: 0x000FCB7D
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

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600AC75 RID: 44149 RVA: 0x000FE98C File Offset: 0x000FCB8C
		// (set) Token: 0x0600AC76 RID: 44150 RVA: 0x000FE9C5 File Offset: 0x000FCBC5
		public TMap<UAnimMontage, UAnimInstance> ClickMontageToAnimInstance
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UAnimMontage, UAnimInstance> result;
				if ((result = this._ClickMontageToAnimInstance) == null)
				{
					result = (this._ClickMontageToAnimInstance = new TMap<UAnimMontage, UAnimInstance>(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_ClickMontageToAnimInstance, this));
				}
				return result;
			}
			set
			{
				this.ClickMontageToAnimInstance.CopyAssign(value);
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600AC77 RID: 44151 RVA: 0x000FE9D4 File Offset: 0x000FCBD4
		// (set) Token: 0x0600AC78 RID: 44152 RVA: 0x000FEA0D File Offset: 0x000FCC0D
		public TSet<UAnimInstance> PendingClickAnimInstances
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UAnimInstance> result;
				if ((result = this._PendingClickAnimInstances) == null)
				{
					result = (this._PendingClickAnimInstances = new TSet<UAnimInstance>(base.NativePtr + (IntPtr)UMovieSceneQteManager.__PropertyOffset_PendingClickAnimInstances, this));
				}
				return result;
			}
			set
			{
				this.PendingClickAnimInstances.CopyAssign(value);
			}
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x000FEA1B File Offset: 0x000FCC1B
		public void UpdateQte(int Id, bool bProgress, float ProgressPercentage)
		{
			UMovieSceneQteManager.__UpdateQte_Internal(base.NativePtr, Id, bProgress, ProgressPercentage);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x000FEA2B File Offset: 0x000FCC2B
		public void QteTriggerInput(int Id)
		{
			UMovieSceneQteManager.__QteTriggerInput_Internal(base.NativePtr, Id);
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x000FEA39 File Offset: 0x000FCC39
		public void OnSequencePaused()
		{
			UMovieSceneQteManager.__OnSequencePaused_Internal(base.NativePtr);
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x000FEA46 File Offset: 0x000FCC46
		[NullableContext(2)]
		public void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
		{
			UMovieSceneQteManager.__OnMontageBlendingOut_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x000FEA64 File Offset: 0x000FCC64
		[NullableContext(2)]
		public void OnClickMontageEnded(UAnimMontage Montage, bool bInterrupted)
		{
			UMovieSceneQteManager.__OnClickMontageEnded_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x000FEA82 File Offset: 0x000FCC82
		public void FinishQte(int Id)
		{
			UMovieSceneQteManager.__FinishQte_Internal(base.NativePtr, Id);
		}

		// Token: 0x0600AC7F RID: 44159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateQte_Internal(IntPtr @this, int Id, bool bProgress, float ProgressPercentage);

		// Token: 0x0600AC80 RID: 44160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __QteTriggerInput_Internal(IntPtr @this, int Id);

		// Token: 0x0600AC81 RID: 44161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSequencePaused_Internal(IntPtr @this);

		// Token: 0x0600AC82 RID: 44162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageBlendingOut_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x0600AC83 RID: 44163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnClickMontageEnded_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x0600AC84 RID: 44164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishQte_Internal(IntPtr @this, int Id);

		// Token: 0x0600AC85 RID: 44165 RVA: 0x000FEA90 File Offset: 0x000FCC90
		static UMovieSceneQteManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteManager");
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x000FEA9E File Offset: 0x000FCC9E
		protected UMovieSceneQteManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A4C RID: 19020
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteManager";

		// Token: 0x04004A4D RID: 19021
		private static IntPtr _ClassPtr;

		// Token: 0x04004A4E RID: 19022
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A4F RID: 19023
		internal static int __PropertyOffset_OnQteAnimEnd;

		// Token: 0x04004A50 RID: 19024
		[Nullable(2)]
		private FOnQteAnimEnd _OnQteAnimEnd;

		// Token: 0x04004A51 RID: 19025
		internal static int __PropertyOffset_OnQteSectionEnd;

		// Token: 0x04004A52 RID: 19026
		[Nullable(2)]
		private FOnQteSectionEnd _OnQteSectionEnd;

		// Token: 0x04004A53 RID: 19027
		internal static int __PropertyOffset_OnQteStart;

		// Token: 0x04004A54 RID: 19028
		[Nullable(2)]
		private FOnQteStart _OnQteStart;

		// Token: 0x04004A55 RID: 19029
		internal static int __PropertyOffset_QteSeqActor;

		// Token: 0x04004A56 RID: 19030
		internal static int __PropertyOffset_MontageToAnimInstance;

		// Token: 0x04004A57 RID: 19031
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UAnimMontage, UAnimInstance> _MontageToAnimInstance;

		// Token: 0x04004A58 RID: 19032
		internal static int __PropertyOffset_ClickMontageToAnimInstance;

		// Token: 0x04004A59 RID: 19033
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UAnimMontage, UAnimInstance> _ClickMontageToAnimInstance;

		// Token: 0x04004A5A RID: 19034
		internal static int __PropertyOffset_PendingClickAnimInstances;

		// Token: 0x04004A5B RID: 19035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UAnimInstance> _PendingClickAnimInstances;
	}
}
