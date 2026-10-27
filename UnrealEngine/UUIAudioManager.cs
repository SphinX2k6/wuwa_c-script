using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002127 RID: 8487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIAudioManager")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UUIAudioManager : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FED2 RID: 130770 RVA: 0x002F7D2C File Offset: 0x002F5F2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIAudioManager._ClassPtr;
		}

		// Token: 0x0601FED3 RID: 130771 RVA: 0x002F7D38 File Offset: 0x002F5F38
		public UUIAudioManager() : this(BuiltinUtils.AllocNativeUObject(UUIAudioManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FED4 RID: 130772 RVA: 0x002F7D60 File Offset: 0x002F5F60
		public UUIAudioManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIAudioManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D86 RID: 32134
		// (get) Token: 0x0601FED5 RID: 130773 RVA: 0x002F7D94 File Offset: 0x002F5F94
		// (set) Token: 0x0601FED6 RID: 130774 RVA: 0x002F7DCD File Offset: 0x002F5FCD
		public TMap<string, FAudioControl> AudioEventMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FAudioControl> result;
				if ((result = this._AudioEventMap) == null)
				{
					result = (this._AudioEventMap = new TMap<string, FAudioControl>(base.NativePtr + (IntPtr)UUIAudioManager.__PropertyOffset_AudioEventMap, this));
				}
				return result;
			}
			set
			{
				this.AudioEventMap.CopyAssign(value);
			}
		}

		// Token: 0x17007D87 RID: 32135
		// (get) Token: 0x0601FED7 RID: 130775 RVA: 0x002F7DDB File Offset: 0x002F5FDB
		// (set) Token: 0x0601FED8 RID: 130776 RVA: 0x002F7DEF File Offset: 0x002F5FEF
		public unsafe string PreviewLevelSequenceByKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIAudioManager.__PropertyOffset_PreviewLevelSequenceByKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIAudioManager.__PropertyOffset_PreviewLevelSequenceByKey)), value);
			}
		}

		// Token: 0x0601FED9 RID: 130777 RVA: 0x002F7E04 File Offset: 0x002F6004
		public void TestPlayPreviewLevelSequenceByKey()
		{
			UUIAudioManager.__TestPlayPreviewLevelSequenceByKey_Internal(base.NativePtr);
		}

		// Token: 0x0601FEDA RID: 130778 RVA: 0x002F7E14 File Offset: 0x002F6014
		public unsafe void StopAudioEventByKey(string EventKey)
		{
			FString fstring = FString.AllocTemp(EventKey);
			UUIAudioManager.__StopAudioEventByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FEDB RID: 130779 RVA: 0x002F7E3E File Offset: 0x002F603E
		public void StopAudioEventAllOnThisActor()
		{
			UUIAudioManager.__StopAudioEventAllOnThisActor_Internal(base.NativePtr);
		}

		// Token: 0x0601FEDC RID: 130780 RVA: 0x002F7E4B File Offset: 0x002F604B
		public void StopAudioEventAll()
		{
			UUIAudioManager.__StopAudioEventAll_Internal(base.NativePtr);
		}

		// Token: 0x0601FEDD RID: 130781 RVA: 0x002F7E58 File Offset: 0x002F6058
		public unsafe void PlayAudioEventByKey(string EventKey)
		{
			FString fstring = FString.AllocTemp(EventKey);
			UUIAudioManager.__PlayAudioEventByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FEDE RID: 130782 RVA: 0x002F7E84 File Offset: 0x002F6084
		public unsafe void OnLevelSequencePlay(string SeqName)
		{
			FString fstring = FString.AllocTemp(SeqName);
			UUIAudioManager.__OnLevelSequencePlay_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FEDF RID: 130783 RVA: 0x002F7EB0 File Offset: 0x002F60B0
		public unsafe void OnLevelSequenceInterrupt(string SeqName)
		{
			FString fstring = FString.AllocTemp(SeqName);
			UUIAudioManager.__OnLevelSequenceInterrupt_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FEE0 RID: 130784 RVA: 0x002F7EDC File Offset: 0x002F60DC
		public unsafe void OnLevelSequenceEnd(string SeqName)
		{
			FString fstring = FString.AllocTemp(SeqName);
			UUIAudioManager.__OnLevelSequenceEnd_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FEE1 RID: 130785 RVA: 0x002F7F06 File Offset: 0x002F6106
		public void CollectLevelSequenceByKey()
		{
			UUIAudioManager.__CollectLevelSequenceByKey_Internal(base.NativePtr);
		}

		// Token: 0x0601FEE2 RID: 130786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestPlayPreviewLevelSequenceByKey_Internal(IntPtr @this);

		// Token: 0x0601FEE3 RID: 130787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAudioEventByKey_Internal(IntPtr @this, in FString EventKey);

		// Token: 0x0601FEE4 RID: 130788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAudioEventAllOnThisActor_Internal(IntPtr @this);

		// Token: 0x0601FEE5 RID: 130789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAudioEventAll_Internal(IntPtr @this);

		// Token: 0x0601FEE6 RID: 130790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAudioEventByKey_Internal(IntPtr @this, in FString EventKey);

		// Token: 0x0601FEE7 RID: 130791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelSequencePlay_Internal(IntPtr @this, in FString SeqName);

		// Token: 0x0601FEE8 RID: 130792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelSequenceInterrupt_Internal(IntPtr @this, in FString SeqName);

		// Token: 0x0601FEE9 RID: 130793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelSequenceEnd_Internal(IntPtr @this, in FString SeqName);

		// Token: 0x0601FEEA RID: 130794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectLevelSequenceByKey_Internal(IntPtr @this);

		// Token: 0x0601FEEB RID: 130795 RVA: 0x002F7F13 File Offset: 0x002F6113
		static UUIAudioManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIAudioManager");
		}

		// Token: 0x0601FEEC RID: 130796 RVA: 0x002F7F21 File Offset: 0x002F6121
		protected UUIAudioManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011338 RID: 70456
		public new const string __ObjectPath = "/Script/LGUI.UIAudioManager";

		// Token: 0x04011339 RID: 70457
		private static IntPtr _ClassPtr;

		// Token: 0x0401133A RID: 70458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401133B RID: 70459
		internal static int __PropertyOffset_AudioEventMap;

		// Token: 0x0401133C RID: 70460
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FAudioControl> _AudioEventMap;

		// Token: 0x0401133D RID: 70461
		internal static int __PropertyOffset_PreviewLevelSequenceByKey;
	}
}
