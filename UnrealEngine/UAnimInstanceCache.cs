using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200080B RID: 2059
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimInstanceCache")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimInstanceCache : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006E9B RID: 28315 RVA: 0x0009EA05 File Offset: 0x0009CC05
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimInstanceCache._ClassPtr;
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x0009EA14 File Offset: 0x0009CC14
		public UAnimInstanceCache() : this(BuiltinUtils.AllocNativeUObject(UAnimInstanceCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x0009EA3C File Offset: 0x0009CC3C
		public UAnimInstanceCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimInstanceCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x0009EA6F File Offset: 0x0009CC6F
		// (set) Token: 0x06006E9F RID: 28319 RVA: 0x0009EA83 File Offset: 0x0009CC83
		[Nullable(2)]
		public unsafe UAnimInstance AnimInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimInstanceCache.__PropertyOffset_AnimInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimInstanceCache.__PropertyOffset_AnimInstance, value);
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x0009EA98 File Offset: 0x0009CC98
		// (set) Token: 0x06006EA1 RID: 28321 RVA: 0x0009EAD1 File Offset: 0x0009CCD1
		public TArray<UAnimInstance> LinkedInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimInstance> result;
				if ((result = this._LinkedInstances) == null)
				{
					result = (this._LinkedInstances = new TArray<UAnimInstance>(base.NativePtr + (IntPtr)UAnimInstanceCache.__PropertyOffset_LinkedInstances, this));
				}
				return result;
			}
			set
			{
				this.LinkedInstances.CopyAssign(value);
			}
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x0009EADF File Offset: 0x0009CCDF
		static UAnimInstanceCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimInstanceCache");
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x0009EAED File Offset: 0x0009CCED
		protected UAnimInstanceCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400351A RID: 13594
		public new const string __ObjectPath = "/Script/Engine.AnimInstanceCache";

		// Token: 0x0400351B RID: 13595
		private static IntPtr _ClassPtr;

		// Token: 0x0400351C RID: 13596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400351D RID: 13597
		internal static int __PropertyOffset_AnimInstance;

		// Token: 0x0400351E RID: 13598
		internal static int __PropertyOffset_LinkedInstances;

		// Token: 0x0400351F RID: 13599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimInstance> _LinkedInstances;
	}
}
