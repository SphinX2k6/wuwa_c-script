using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019AE RID: 6574
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelPlaySequence")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroLevelPlaySequence : UKuroLevelStateAction, IUnrealUObject, IUnrealObject, IMovieScenePlaybackClient, IUnrealNativeInterface, IUnrealInterface, IMovieSceneBindingOwnerInterface
	{
		// Token: 0x0601875A RID: 100186 RVA: 0x00240B62 File Offset: 0x0023ED62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlaySequence._ClassPtr;
		}

		// Token: 0x0601875B RID: 100187 RVA: 0x00240B6E File Offset: 0x0023ED6E
		int IMovieScenePlaybackClient.InterfaceOffset()
		{
			return UKuroLevelPlaySequence.__InterfaceOffset_IMovieScenePlaybackClient;
		}

		// Token: 0x0601875C RID: 100188 RVA: 0x00240B75 File Offset: 0x0023ED75
		int IMovieSceneBindingOwnerInterface.InterfaceOffset()
		{
			return UKuroLevelPlaySequence.__InterfaceOffset_IMovieSceneBindingOwnerInterface;
		}

		// Token: 0x0601875D RID: 100189 RVA: 0x00240B7C File Offset: 0x0023ED7C
		public UKuroLevelPlaySequence() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601875E RID: 100190 RVA: 0x00240BA4 File Offset: 0x0023EDA4
		[NullableContext(1)]
		public UKuroLevelPlaySequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061AE RID: 25006
		// (get) Token: 0x0601875F RID: 100191 RVA: 0x00240BD7 File Offset: 0x0023EDD7
		// (set) Token: 0x06018760 RID: 100192 RVA: 0x00240BEB File Offset: 0x0023EDEB
		[Nullable(2)]
		public unsafe ULevelSequence LevelSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlaySequence.__PropertyOffset_LevelSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlaySequence.__PropertyOffset_LevelSequence, value);
			}
		}

		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x06018761 RID: 100193 RVA: 0x00240C00 File Offset: 0x0023EE00
		// (set) Token: 0x06018762 RID: 100194 RVA: 0x00240C10 File Offset: 0x0023EE10
		public unsafe bool bIsLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlaySequence.__PropertyOffset_bIsLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlaySequence.__PropertyOffset_bIsLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x06018763 RID: 100195 RVA: 0x00240C21 File Offset: 0x0023EE21
		// (set) Token: 0x06018764 RID: 100196 RVA: 0x00240C31 File Offset: 0x0023EE31
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlaySequence.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlaySequence.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x06018765 RID: 100197 RVA: 0x00240C44 File Offset: 0x0023EE44
		// (set) Token: 0x06018766 RID: 100198 RVA: 0x00240C7D File Offset: 0x0023EE7D
		[Nullable(1)]
		public TArray<FKuroLevelPlaySequenceOverrideData> OverrideData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelPlaySequenceOverrideData> result;
				if ((result = this._OverrideData) == null)
				{
					result = (this._OverrideData = new TArray<FKuroLevelPlaySequenceOverrideData>(base.NativePtr + (IntPtr)UKuroLevelPlaySequence.__PropertyOffset_OverrideData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverrideData.CopyAssign(value);
			}
		}

		// Token: 0x06018767 RID: 100199 RVA: 0x00240C8B File Offset: 0x0023EE8B
		static UKuroLevelPlaySequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelPlaySequence");
		}

		// Token: 0x06018768 RID: 100200 RVA: 0x00240C99 File Offset: 0x0023EE99
		protected UKuroLevelPlaySequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D36B RID: 54123
		internal static int __InterfaceOffset_IMovieScenePlaybackClient;

		// Token: 0x0400D36C RID: 54124
		internal static int __InterfaceOffset_IMovieSceneBindingOwnerInterface;

		// Token: 0x0400D36D RID: 54125
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelPlaySequence";

		// Token: 0x0400D36E RID: 54126
		private static IntPtr _ClassPtr;

		// Token: 0x0400D36F RID: 54127
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D370 RID: 54128
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x0400D371 RID: 54129
		internal static int __PropertyOffset_bIsLoop;

		// Token: 0x0400D372 RID: 54130
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x0400D373 RID: 54131
		internal static int __PropertyOffset_OverrideData;

		// Token: 0x0400D374 RID: 54132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelPlaySequenceOverrideData> _OverrideData;
	}
}
