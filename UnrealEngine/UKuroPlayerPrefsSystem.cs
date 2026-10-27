using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B8D RID: 7053
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPlayerPrefsSystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroPlayerPrefsSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AC26 RID: 109606 RVA: 0x00276F22 File Offset: 0x00275122
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPlayerPrefsSystem._ClassPtr;
		}

		// Token: 0x0601AC27 RID: 109607 RVA: 0x00276F30 File Offset: 0x00275130
		public UKuroPlayerPrefsSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroPlayerPrefsSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AC28 RID: 109608 RVA: 0x00276F58 File Offset: 0x00275158
		public UKuroPlayerPrefsSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPlayerPrefsSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006BA1 RID: 27553
		// (get) Token: 0x0601AC29 RID: 109609 RVA: 0x00276F8B File Offset: 0x0027518B
		// (set) Token: 0x0601AC2A RID: 109610 RVA: 0x00276F9F File Offset: 0x0027519F
		[Nullable(2)]
		public unsafe UKuroSaveGame KuroSaveGame
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSaveGame>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPlayerPrefsSystem.__PropertyOffset_KuroSaveGame);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPlayerPrefsSystem.__PropertyOffset_KuroSaveGame, value);
			}
		}

		// Token: 0x0601AC2B RID: 109611 RVA: 0x00276FB4 File Offset: 0x002751B4
		public unsafe void SetString(string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			UKuroPlayerPrefsSystem.__SetString_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601AC2C RID: 109612 RVA: 0x00276FF0 File Offset: 0x002751F0
		public unsafe void SetInt(string Key, int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroPlayerPrefsSystem.__SetInt_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AC2D RID: 109613 RVA: 0x0027701C File Offset: 0x0027521C
		public unsafe void SetFloat(string Key, float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroPlayerPrefsSystem.__SetFloat_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AC2E RID: 109614 RVA: 0x00277047 File Offset: 0x00275247
		public void Save()
		{
			UKuroPlayerPrefsSystem.__Save_Internal(base.NativePtr);
		}

		// Token: 0x0601AC2F RID: 109615 RVA: 0x00277054 File Offset: 0x00275254
		public unsafe bool HasKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroPlayerPrefsSystem.__HasKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AC30 RID: 109616 RVA: 0x00277080 File Offset: 0x00275280
		public unsafe string GetString(string Key, string DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(DefaultValue);
			string result = FString.ToStringAndDeleteNativePtr(UKuroPlayerPrefsSystem.__GetString_Internal(base.NativePtr, fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601AC31 RID: 109617 RVA: 0x002770C4 File Offset: 0x002752C4
		public unsafe int GetInt(string Key, int DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			int result = UKuroPlayerPrefsSystem.__GetInt_Internal(base.NativePtr, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AC32 RID: 109618 RVA: 0x002770F0 File Offset: 0x002752F0
		public unsafe float GetFloat(string Key, float DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			float result = UKuroPlayerPrefsSystem.__GetFloat_Internal(base.NativePtr, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AC33 RID: 109619 RVA: 0x0027711C File Offset: 0x0027531C
		public unsafe void DeleteKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroPlayerPrefsSystem.__DeleteKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AC34 RID: 109620 RVA: 0x00277146 File Offset: 0x00275346
		public void DeleteAll()
		{
			UKuroPlayerPrefsSystem.__DeleteAll_Internal(base.NativePtr);
		}

		// Token: 0x0601AC35 RID: 109621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetString_Internal(IntPtr @this, in FString Key, in FString Value);

		// Token: 0x0601AC36 RID: 109622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInt_Internal(IntPtr @this, in FString Key, int Value);

		// Token: 0x0601AC37 RID: 109623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloat_Internal(IntPtr @this, in FString Key, float Value);

		// Token: 0x0601AC38 RID: 109624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Save_Internal(IntPtr @this);

		// Token: 0x0601AC39 RID: 109625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0601AC3A RID: 109626
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetString_Internal(IntPtr @this, in FString Key, in FString DefaultValue);

		// Token: 0x0601AC3B RID: 109627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInt_Internal(IntPtr @this, in FString Key, int DefaultValue);

		// Token: 0x0601AC3C RID: 109628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloat_Internal(IntPtr @this, in FString Key, float DefaultValue);

		// Token: 0x0601AC3D RID: 109629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0601AC3E RID: 109630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteAll_Internal(IntPtr @this);

		// Token: 0x0601AC3F RID: 109631 RVA: 0x00277153 File Offset: 0x00275353
		static UKuroPlayerPrefsSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPlayerPrefsSystem");
		}

		// Token: 0x0601AC40 RID: 109632 RVA: 0x00277161 File Offset: 0x00275361
		protected UKuroPlayerPrefsSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E7A2 RID: 59298
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPlayerPrefsSystem";

		// Token: 0x0400E7A3 RID: 59299
		private static IntPtr _ClassPtr;

		// Token: 0x0400E7A4 RID: 59300
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E7A5 RID: 59301
		internal static int __PropertyOffset_KuroSaveGame;
	}
}
