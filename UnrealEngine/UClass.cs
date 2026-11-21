using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200007D RID: 125
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.Class")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class UClass : UStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00013500 File Offset: 0x00011700
		public UClassStackOnlyPtr ClassStackOnlyPtr
		{
			get
			{
				return new UClassStackOnlyPtr(base.NativePtr);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0001350D File Offset: 0x0001170D
		public static implicit operator UClassStackOnlyPtr(UClass @class)
		{
			return new UClassStackOnlyPtr(@class.NativePtr);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0001351C File Offset: 0x0001171C
		[NullableContext(2)]
		public bool IsChildOf(UClass Class)
		{
			return UClass.IsChildOf(this.ClassStackOnlyPtr, (Class != null) ? Class.ClassStackOnlyPtr : default(UClassStackOnlyPtr));
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00013548 File Offset: 0x00011748
		public bool IsChildOf(UClassStackOnlyPtr Class)
		{
			return UClass.IsChildOf(this.ClassStackOnlyPtr, Class);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00013558 File Offset: 0x00011758
		[NullableContext(2)]
		public bool IsA(UClass Class)
		{
			return UClass.IsA(this.ClassStackOnlyPtr, (Class != null) ? Class.ClassStackOnlyPtr : default(UClassStackOnlyPtr));
		}

		// Token: 0x06000BE1 RID: 3041
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValid(UClassStackOnlyPtr Class);

		// Token: 0x06000BE2 RID: 3042
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsChildOf(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x06000BE3 RID: 3043
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsA(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x06000BE4 RID: 3044
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FName GetFName(UClassStackOnlyPtr Class);

		// Token: 0x06000BE5 RID: 3045
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetName(UClassStackOnlyPtr Class);

		// Token: 0x06000BE6 RID: 3046
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetPathName(UClassStackOnlyPtr Class);

		// Token: 0x06000BE7 RID: 3047
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern UClassStackOnlyPtr GetClass(UClassStackOnlyPtr Class);

		// Token: 0x06000BE8 RID: 3048
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetObjectIndex(UClassStackOnlyPtr Class);

		// Token: 0x06000BE9 RID: 3049
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetObjectSerialNumber(UClassStackOnlyPtr Class);

		// Token: 0x06000BEA RID: 3050 RVA: 0x00013584 File Offset: 0x00011784
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClass._ClassPtr;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00013590 File Offset: 0x00011790
		public UClass() : this(BuiltinUtils.AllocNativeUObject(UClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000135B8 File Offset: 0x000117B8
		public UClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000135EB File Offset: 0x000117EB
		static UClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Class");
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000135F9 File Offset: 0x000117F9
		protected UClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040001B6 RID: 438
		public new const string __ObjectPath = "/Script/CoreUObject.Class";

		// Token: 0x040001B7 RID: 439
		private static IntPtr _ClassPtr;

		// Token: 0x040001B8 RID: 440
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
