using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CE8 RID: 3304
	[UnrealObjectPath("/Script/Engine.KuroCustomMovementExtension")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UKuroCustomMovementExtension : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AF53 RID: 44883 RVA: 0x000F8B3F File Offset: 0x000F6D3F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomMovementExtension._ClassPtr;
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x000F8B4B File Offset: 0x000F6D4B
		// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x000F8B5B File Offset: 0x000F6D5B
		public unsafe float MaxIterationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationTime) = value;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x000F8B6C File Offset: 0x000F6D6C
		// (set) Token: 0x0600AF57 RID: 44887 RVA: 0x000F8B7C File Offset: 0x000F6D7C
		public unsafe int MaxIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationCount) = value;
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x000F8B8D File Offset: 0x000F6D8D
		// (set) Token: 0x0600AF59 RID: 44889 RVA: 0x000F8BA1 File Offset: 0x000F6DA1
		[Nullable(2)]
		public unsafe UCharacterMovementComponent MovementComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCharacterMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomMovementExtension.__PropertyOffset_MovementComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomMovementExtension.__PropertyOffset_MovementComponent, value);
			}
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x000F8BB6 File Offset: 0x000F6DB6
		static UKuroCustomMovementExtension()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroCustomMovementExtension");
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x000F8BC4 File Offset: 0x000F6DC4
		protected UKuroCustomMovementExtension() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomMovementExtension.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x000F8BEC File Offset: 0x000F6DEC
		protected UKuroCustomMovementExtension(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005BCF RID: 23503
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroCustomMovementExtension";

		// Token: 0x04005BD0 RID: 23504
		private static IntPtr _ClassPtr;

		// Token: 0x04005BD1 RID: 23505
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005BD2 RID: 23506
		internal static int __PropertyOffset_MaxIterationTime;

		// Token: 0x04005BD3 RID: 23507
		internal static int __PropertyOffset_MaxIterationCount;

		// Token: 0x04005BD4 RID: 23508
		internal static int __PropertyOffset_MovementComponent;
	}
}
