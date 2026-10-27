using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB8 RID: 8120
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceBurnInOptions")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class ULevelSequenceBurnInOptions : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED20 RID: 126240 RVA: 0x002DCEA2 File Offset: 0x002DB0A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequenceBurnInOptions._ClassPtr;
		}

		// Token: 0x0601ED21 RID: 126241 RVA: 0x002DCEB0 File Offset: 0x002DB0B0
		public ULevelSequenceBurnInOptions() : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceBurnInOptions.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED22 RID: 126242 RVA: 0x002DCED8 File Offset: 0x002DB0D8
		public ULevelSequenceBurnInOptions(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceBurnInOptions.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007AB8 RID: 31416
		// (get) Token: 0x0601ED23 RID: 126243 RVA: 0x002DCF0B File Offset: 0x002DB10B
		// (set) Token: 0x0601ED24 RID: 126244 RVA: 0x002DCF1B File Offset: 0x002DB11B
		public unsafe bool bUseBurnIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelSequenceBurnInOptions.__PropertyOffset_bUseBurnIn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelSequenceBurnInOptions.__PropertyOffset_bUseBurnIn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007AB9 RID: 31417
		// (get) Token: 0x0601ED25 RID: 126245 RVA: 0x002DCF2C File Offset: 0x002DB12C
		// (set) Token: 0x0601ED26 RID: 126246 RVA: 0x002DCF65 File Offset: 0x002DB165
		public FSoftClassPath BurnInClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._BurnInClass) == null)
				{
					result = (this._BurnInClass = new FSoftClassPath(base.NativePtr + (IntPtr)ULevelSequenceBurnInOptions.__PropertyOffset_BurnInClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)ULevelSequenceBurnInOptions.__PropertyOffset_BurnInClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007ABA RID: 31418
		// (get) Token: 0x0601ED27 RID: 126247 RVA: 0x002DCF86 File Offset: 0x002DB186
		// (set) Token: 0x0601ED28 RID: 126248 RVA: 0x002DCF9A File Offset: 0x002DB19A
		[Nullable(2)]
		public unsafe ULevelSequenceBurnInInitSettings Settings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequenceBurnInInitSettings>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequenceBurnInOptions.__PropertyOffset_Settings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequenceBurnInOptions.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x0601ED29 RID: 126249 RVA: 0x002DCFAF File Offset: 0x002DB1AF
		[NullableContext(2)]
		public void SetBurnIn(FSoftClassPath InBurnInClass)
		{
			ULevelSequenceBurnInOptions.__SetBurnIn_Internal(base.NativePtr, (InBurnInClass ?? new FSoftClassPath()).NativePtr);
		}

		// Token: 0x0601ED2A RID: 126250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBurnIn_Internal(IntPtr @this, IntPtr InBurnInClass);

		// Token: 0x0601ED2B RID: 126251 RVA: 0x002DCFCB File Offset: 0x002DB1CB
		static ULevelSequenceBurnInOptions()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceBurnInOptions");
		}

		// Token: 0x0601ED2C RID: 126252 RVA: 0x002DCFD9 File Offset: 0x002DB1D9
		protected ULevelSequenceBurnInOptions(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A84 RID: 68228
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceBurnInOptions";

		// Token: 0x04010A85 RID: 68229
		private static IntPtr _ClassPtr;

		// Token: 0x04010A86 RID: 68230
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A87 RID: 68231
		internal static int __PropertyOffset_bUseBurnIn;

		// Token: 0x04010A88 RID: 68232
		internal static int __PropertyOffset_BurnInClass;

		// Token: 0x04010A89 RID: 68233
		[Nullable(2)]
		private FSoftClassPath _BurnInClass;

		// Token: 0x04010A8A RID: 68234
		internal static int __PropertyOffset_Settings;
	}
}
