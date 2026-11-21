using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D8 RID: 1240
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPlayerPrefsSystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroPlayerPrefsSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073B3 RID: 29619 RVA: 0x000A999A File Offset: 0x000A7B9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPlayerPrefsSystem._ClassPtr;
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x000A99A8 File Offset: 0x000A7BA8
		public UKuroPlayerPrefsSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroPlayerPrefsSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x000A99D0 File Offset: 0x000A7BD0
		public UKuroPlayerPrefsSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPlayerPrefsSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x000A9A04 File Offset: 0x000A7C04
		public unsafe void SetString(string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			UKuroPlayerPrefsSystem.__SetString_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x000A9A40 File Offset: 0x000A7C40
		public unsafe void SetInt(string Key, int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroPlayerPrefsSystem.__SetInt_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x000A9A6C File Offset: 0x000A7C6C
		public unsafe void SetFloat(string Key, float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroPlayerPrefsSystem.__SetFloat_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x000A9A97 File Offset: 0x000A7C97
		public void Save()
		{
			UKuroPlayerPrefsSystem.__Save_Internal(base.NativePtr);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x000A9AA4 File Offset: 0x000A7CA4
		public unsafe bool HasKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroPlayerPrefsSystem.__HasKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x000A9AD0 File Offset: 0x000A7CD0
		public unsafe string GetString(string Key, string DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(DefaultValue);
			string result = FString.ToStringAndDeleteNativePtr(UKuroPlayerPrefsSystem.__GetString_Internal(base.NativePtr, fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x000A9B14 File Offset: 0x000A7D14
		public unsafe int GetInt(string Key, int DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			int result = UKuroPlayerPrefsSystem.__GetInt_Internal(base.NativePtr, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x000A9B40 File Offset: 0x000A7D40
		public unsafe float GetFloat(string Key, float DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			float result = UKuroPlayerPrefsSystem.__GetFloat_Internal(base.NativePtr, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x000A9B6C File Offset: 0x000A7D6C
		public unsafe void DeleteKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroPlayerPrefsSystem.__DeleteKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x000A9B96 File Offset: 0x000A7D96
		public void DeleteAll()
		{
			UKuroPlayerPrefsSystem.__DeleteAll_Internal(base.NativePtr);
		}

		// Token: 0x060073C0 RID: 29632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetString_Internal(IntPtr @this, in FString Key, in FString Value);

		// Token: 0x060073C1 RID: 29633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInt_Internal(IntPtr @this, in FString Key, int Value);

		// Token: 0x060073C2 RID: 29634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloat_Internal(IntPtr @this, in FString Key, float Value);

		// Token: 0x060073C3 RID: 29635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Save_Internal(IntPtr @this);

		// Token: 0x060073C4 RID: 29636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x060073C5 RID: 29637
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetString_Internal(IntPtr @this, in FString Key, in FString DefaultValue);

		// Token: 0x060073C6 RID: 29638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInt_Internal(IntPtr @this, in FString Key, int DefaultValue);

		// Token: 0x060073C7 RID: 29639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloat_Internal(IntPtr @this, in FString Key, float DefaultValue);

		// Token: 0x060073C8 RID: 29640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x060073C9 RID: 29641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteAll_Internal(IntPtr @this);

		// Token: 0x060073CA RID: 29642 RVA: 0x000A9BA3 File Offset: 0x000A7DA3
		static UKuroPlayerPrefsSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPlayerPrefsSystem");
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x000A9BB1 File Offset: 0x000A7DB1
		protected UKuroPlayerPrefsSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003193 RID: 12691
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPlayerPrefsSystem";

		// Token: 0x04003194 RID: 12692
		private static IntPtr _ClassPtr;

		// Token: 0x04003195 RID: 12693
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
