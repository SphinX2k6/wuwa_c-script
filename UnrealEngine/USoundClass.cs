using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001126 RID: 4390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundClass")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class USoundClass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060100F8 RID: 65784 RVA: 0x0017A8C5 File Offset: 0x00178AC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundClass._ClassPtr;
		}

		// Token: 0x060100F9 RID: 65785 RVA: 0x0017A8D4 File Offset: 0x00178AD4
		public USoundClass() : this(BuiltinUtils.AllocNativeUObject(USoundClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060100FA RID: 65786 RVA: 0x0017A8FC File Offset: 0x00178AFC
		public USoundClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x060100FB RID: 65787 RVA: 0x0017A930 File Offset: 0x00178B30
		// (set) Token: 0x060100FC RID: 65788 RVA: 0x0017A969 File Offset: 0x00178B69
		public FSoundClassProperties Properties
		{
			get
			{
				base.FastCheckIsValid();
				FSoundClassProperties result;
				if ((result = this._Properties) == null)
				{
					result = (this._Properties = new FSoundClassProperties(base.NativePtr + (IntPtr)USoundClass.__PropertyOffset_Properties, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundClassProperties.StaticStruct(), base.NativePtr + (IntPtr)USoundClass.__PropertyOffset_Properties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x060100FD RID: 65789 RVA: 0x0017A98C File Offset: 0x00178B8C
		// (set) Token: 0x060100FE RID: 65790 RVA: 0x0017A9C5 File Offset: 0x00178BC5
		public TArray<USoundClass> ChildClasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USoundClass> result;
				if ((result = this._ChildClasses) == null)
				{
					result = (this._ChildClasses = new TArray<USoundClass>(base.NativePtr + (IntPtr)USoundClass.__PropertyOffset_ChildClasses, this));
				}
				return result;
			}
			set
			{
				this.ChildClasses.CopyAssign(value);
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x060100FF RID: 65791 RVA: 0x0017A9D4 File Offset: 0x00178BD4
		// (set) Token: 0x06010100 RID: 65792 RVA: 0x0017AA0D File Offset: 0x00178C0D
		public TArray<FPassiveSoundMixModifier> PassiveSoundMixModifiers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPassiveSoundMixModifier> result;
				if ((result = this._PassiveSoundMixModifiers) == null)
				{
					result = (this._PassiveSoundMixModifiers = new TArray<FPassiveSoundMixModifier>(base.NativePtr + (IntPtr)USoundClass.__PropertyOffset_PassiveSoundMixModifiers, this));
				}
				return result;
			}
			set
			{
				this.PassiveSoundMixModifiers.CopyAssign(value);
			}
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x06010101 RID: 65793 RVA: 0x0017AA1B File Offset: 0x00178C1B
		// (set) Token: 0x06010102 RID: 65794 RVA: 0x0017AA2F File Offset: 0x00178C2F
		[Nullable(2)]
		public unsafe USoundClass ParentClass
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundClass>(base.NativePtr / (IntPtr)sizeof(void*) + USoundClass.__PropertyOffset_ParentClass);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundClass.__PropertyOffset_ParentClass, value);
			}
		}

		// Token: 0x06010103 RID: 65795 RVA: 0x0017AA44 File Offset: 0x00178C44
		static USoundClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundClass");
		}

		// Token: 0x06010104 RID: 65796 RVA: 0x0017AA52 File Offset: 0x00178C52
		protected USoundClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A23 RID: 35363
		public new const string __ObjectPath = "/Script/Engine.SoundClass";

		// Token: 0x04008A24 RID: 35364
		private static IntPtr _ClassPtr;

		// Token: 0x04008A25 RID: 35365
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A26 RID: 35366
		internal static int __PropertyOffset_Properties;

		// Token: 0x04008A27 RID: 35367
		[Nullable(2)]
		private FSoundClassProperties _Properties;

		// Token: 0x04008A28 RID: 35368
		internal static int __PropertyOffset_ChildClasses;

		// Token: 0x04008A29 RID: 35369
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundClass> _ChildClasses;

		// Token: 0x04008A2A RID: 35370
		internal static int __PropertyOffset_PassiveSoundMixModifiers;

		// Token: 0x04008A2B RID: 35371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPassiveSoundMixModifier> _PassiveSoundMixModifiers;

		// Token: 0x04008A2C RID: 35372
		internal static int __PropertyOffset_ParentClass;
	}
}
