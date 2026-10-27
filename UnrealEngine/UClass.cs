using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000098 RID: 152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.Class")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class UClass : UStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000187DC File Offset: 0x000169DC
		public UClassStackOnlyPtr ClassStackOnlyPtr
		{
			get
			{
				return new UClassStackOnlyPtr(base.NativePtr);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000187E9 File Offset: 0x000169E9
		public static implicit operator UClassStackOnlyPtr(UClass @class)
		{
			return new UClassStackOnlyPtr(@class.NativePtr);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000187F8 File Offset: 0x000169F8
		[NullableContext(2)]
		public bool IsChildOf(UClass Class)
		{
			return UClass.IsChildOf(this.ClassStackOnlyPtr, (Class != null) ? Class.ClassStackOnlyPtr : default(UClassStackOnlyPtr));
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00018824 File Offset: 0x00016A24
		public bool IsChildOf(UClassStackOnlyPtr Class)
		{
			return UClass.IsChildOf(this.ClassStackOnlyPtr, Class);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00018834 File Offset: 0x00016A34
		[NullableContext(2)]
		public bool IsA(UClass Class)
		{
			return UClass.IsA(this.ClassStackOnlyPtr, (Class != null) ? Class.ClassStackOnlyPtr : default(UClassStackOnlyPtr));
		}

		// Token: 0x0600104E RID: 4174
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValid(UClassStackOnlyPtr Class);

		// Token: 0x0600104F RID: 4175
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsChildOf(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x06001050 RID: 4176
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsA(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x06001051 RID: 4177
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FName GetFName(UClassStackOnlyPtr Class);

		// Token: 0x06001052 RID: 4178
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetName(UClassStackOnlyPtr Class);

		// Token: 0x06001053 RID: 4179
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetPathName(UClassStackOnlyPtr Class);

		// Token: 0x06001054 RID: 4180
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern UClassStackOnlyPtr GetClass(UClassStackOnlyPtr Class);

		// Token: 0x06001055 RID: 4181
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetObjectIndex(UClassStackOnlyPtr Class);

		// Token: 0x06001056 RID: 4182
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetObjectSerialNumber(UClassStackOnlyPtr Class);

		// Token: 0x06001057 RID: 4183 RVA: 0x00018860 File Offset: 0x00016A60
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClass._ClassPtr;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0001886C File Offset: 0x00016A6C
		public UClass() : this(BuiltinUtils.AllocNativeUObject(UClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00018894 File Offset: 0x00016A94
		public UClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000188C7 File Offset: 0x00016AC7
		static UClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Class");
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000188D5 File Offset: 0x00016AD5
		protected UClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040001FD RID: 509
		public new const string __ObjectPath = "/Script/CoreUObject.Class";

		// Token: 0x040001FE RID: 510
		private static IntPtr _ClassPtr;

		// Token: 0x040001FF RID: 511
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
