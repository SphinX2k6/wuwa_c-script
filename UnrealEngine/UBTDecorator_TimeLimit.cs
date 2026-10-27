using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014B RID: 331
	[UnrealObjectPath("/Script/AIModule.BTDecorator_TimeLimit")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UBTDecorator_TimeLimit : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x00021AF2 File Offset: 0x0001FCF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_TimeLimit._ClassPtr;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00021B00 File Offset: 0x0001FD00
		public UBTDecorator_TimeLimit() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_TimeLimit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00021B28 File Offset: 0x0001FD28
		[NullableContext(1)]
		public UBTDecorator_TimeLimit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_TimeLimit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00021B5B File Offset: 0x0001FD5B
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00021B6B File Offset: 0x0001FD6B
		public unsafe float TimeLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_TimeLimit.__PropertyOffset_TimeLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_TimeLimit.__PropertyOffset_TimeLimit) = value;
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00021B7C File Offset: 0x0001FD7C
		static UBTDecorator_TimeLimit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_TimeLimit");
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00021B8A File Offset: 0x0001FD8A
		protected UBTDecorator_TimeLimit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400055B RID: 1371
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_TimeLimit";

		// Token: 0x0400055C RID: 1372
		private static IntPtr _ClassPtr;

		// Token: 0x0400055D RID: 1373
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400055E RID: 1374
		internal static int __PropertyOffset_TimeLimit;
	}
}
