using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB6 RID: 8118
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceBurnIn")]
	[UnrealStructLayout(1360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1360)]
	public class ULevelSequenceBurnIn : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED0C RID: 126220 RVA: 0x002DCCDF File Offset: 0x002DAEDF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequenceBurnIn._ClassPtr;
		}

		// Token: 0x0601ED0D RID: 126221 RVA: 0x002DCCEC File Offset: 0x002DAEEC
		public ULevelSequenceBurnIn() : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceBurnIn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED0E RID: 126222 RVA: 0x002DCD14 File Offset: 0x002DAF14
		[NullableContext(1)]
		public ULevelSequenceBurnIn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceBurnIn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007AB6 RID: 31414
		// (get) Token: 0x0601ED0F RID: 126223 RVA: 0x002DCD48 File Offset: 0x002DAF48
		// (set) Token: 0x0601ED10 RID: 126224 RVA: 0x002DCD81 File Offset: 0x002DAF81
		[Nullable(1)]
		public FLevelSequencePlayerSnapshot FrameInformation
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLevelSequencePlayerSnapshot result;
				if ((result = this._FrameInformation) == null)
				{
					result = (this._FrameInformation = new FLevelSequencePlayerSnapshot(base.NativePtr + (IntPtr)ULevelSequenceBurnIn.__PropertyOffset_FrameInformation, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLevelSequencePlayerSnapshot.StaticStruct(), base.NativePtr + (IntPtr)ULevelSequenceBurnIn.__PropertyOffset_FrameInformation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AB7 RID: 31415
		// (get) Token: 0x0601ED11 RID: 126225 RVA: 0x002DCDA2 File Offset: 0x002DAFA2
		// (set) Token: 0x0601ED12 RID: 126226 RVA: 0x002DCDB6 File Offset: 0x002DAFB6
		[Nullable(2)]
		public unsafe ALevelSequenceActor LevelSequenceActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequenceBurnIn.__PropertyOffset_LevelSequenceActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequenceBurnIn.__PropertyOffset_LevelSequenceActor, value);
			}
		}

		// Token: 0x0601ED13 RID: 126227 RVA: 0x002DCDCB File Offset: 0x002DAFCB
		[NullableContext(2)]
		public virtual void SetSettings(UObject InSettings)
		{
			ULevelSequenceBurnIn.__SetSettings_Internal(base.NativePtr, (InSettings != null) ? InSettings.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601ED14 RID: 126228 RVA: 0x002DCDE8 File Offset: 0x002DAFE8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual TSubclassOf<ULevelSequenceBurnInInitSettings> GetSettingsClass()
		{
			return ULevelSequenceBurnIn.__GetSettingsClass_Internal(base.NativePtr);
		}

		// Token: 0x0601ED15 RID: 126229 RVA: 0x002DCDFA File Offset: 0x002DAFFA
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected virtual TSubclassOf<ULevelSequenceBurnInInitSettings> GetSettingsClass_Implementation()
		{
			return ULevelSequenceBurnIn.__GetSettingsClass_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601ED16 RID: 126230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x0601ED17 RID: 126231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSettingsClass_Internal(IntPtr @this);

		// Token: 0x0601ED18 RID: 126232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSettingsClass_Implementation_Internal(IntPtr @this);

		// Token: 0x0601ED19 RID: 126233 RVA: 0x002DCE0C File Offset: 0x002DB00C
		static ULevelSequenceBurnIn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceBurnIn");
		}

		// Token: 0x0601ED1A RID: 126234 RVA: 0x002DCE1A File Offset: 0x002DB01A
		protected ULevelSequenceBurnIn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A7B RID: 68219
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceBurnIn";

		// Token: 0x04010A7C RID: 68220
		private static IntPtr _ClassPtr;

		// Token: 0x04010A7D RID: 68221
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A7E RID: 68222
		internal static int __PropertyOffset_FrameInformation;

		// Token: 0x04010A7F RID: 68223
		[Nullable(2)]
		private FLevelSequencePlayerSnapshot _FrameInformation;

		// Token: 0x04010A80 RID: 68224
		internal static int __PropertyOffset_LevelSequenceActor;

		// Token: 0x0200341D RID: 13341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSettings_FunctionParams
		{
			// Token: 0x040173F6 RID: 95222
			[FieldOffset(0)]
			public IntPtr InSettings;
		}

		// Token: 0x0200341E RID: 13342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSettingsClass_FunctionParams
		{
			// Token: 0x040173F7 RID: 95223
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<ULevelSequenceBurnInInitSettings> __Result;
		}
	}
}
