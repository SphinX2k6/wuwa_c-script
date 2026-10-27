using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001158 RID: 4440
	[UnrealObjectPath("/Script/Engine.SoundSubmixWithParentBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class USoundSubmixWithParentBase : USoundSubmixBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010397 RID: 66455 RVA: 0x0017E81D File Offset: 0x0017CA1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundSubmixWithParentBase._ClassPtr;
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x06010398 RID: 66456 RVA: 0x0017E829 File Offset: 0x0017CA29
		// (set) Token: 0x06010399 RID: 66457 RVA: 0x0017E83D File Offset: 0x0017CA3D
		[Nullable(2)]
		public unsafe USoundSubmixBase ParentSubmix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmixBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundSubmixWithParentBase.__PropertyOffset_ParentSubmix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundSubmixWithParentBase.__PropertyOffset_ParentSubmix, value);
			}
		}

		// Token: 0x0601039A RID: 66458 RVA: 0x0017E852 File Offset: 0x0017CA52
		static USoundSubmixWithParentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundSubmixWithParentBase");
		}

		// Token: 0x0601039B RID: 66459 RVA: 0x0017E860 File Offset: 0x0017CA60
		protected USoundSubmixWithParentBase() : this(BuiltinUtils.AllocNativeUObject(USoundSubmixWithParentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601039C RID: 66460 RVA: 0x0017E888 File Offset: 0x0017CA88
		protected USoundSubmixWithParentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008BA8 RID: 35752
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundSubmixWithParentBase";

		// Token: 0x04008BA9 RID: 35753
		private static IntPtr _ClassPtr;

		// Token: 0x04008BAA RID: 35754
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008BAB RID: 35755
		internal static int __PropertyOffset_ParentSubmix;
	}
}
