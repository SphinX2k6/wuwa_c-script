using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001155 RID: 4437
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundSubmixBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class USoundSubmixBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010367 RID: 66407 RVA: 0x0017E44E File Offset: 0x0017C64E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundSubmixBase._ClassPtr;
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x06010368 RID: 66408 RVA: 0x0017E45C File Offset: 0x0017C65C
		// (set) Token: 0x06010369 RID: 66409 RVA: 0x0017E495 File Offset: 0x0017C695
		public TArray<USoundSubmixBase> ChildSubmixes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USoundSubmixBase> result;
				if ((result = this._ChildSubmixes) == null)
				{
					result = (this._ChildSubmixes = new TArray<USoundSubmixBase>(base.NativePtr + (IntPtr)USoundSubmixBase.__PropertyOffset_ChildSubmixes, this));
				}
				return result;
			}
			set
			{
				this.ChildSubmixes.CopyAssign(value);
			}
		}

		// Token: 0x0601036A RID: 66410 RVA: 0x0017E4A3 File Offset: 0x0017C6A3
		static USoundSubmixBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundSubmixBase");
		}

		// Token: 0x0601036B RID: 66411 RVA: 0x0017E4B4 File Offset: 0x0017C6B4
		protected USoundSubmixBase() : this(BuiltinUtils.AllocNativeUObject(USoundSubmixBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601036C RID: 66412 RVA: 0x0017E4DC File Offset: 0x0017C6DC
		protected USoundSubmixBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B91 RID: 35729
		public new const string __ObjectPath = "/Script/Engine.SoundSubmixBase";

		// Token: 0x04008B92 RID: 35730
		private static IntPtr _ClassPtr;

		// Token: 0x04008B93 RID: 35731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B94 RID: 35732
		internal static int __PropertyOffset_ChildSubmixes;

		// Token: 0x04008B95 RID: 35733
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundSubmixBase> _ChildSubmixes;
	}
}
