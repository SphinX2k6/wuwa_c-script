using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001134 RID: 4404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundGroups")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class USoundGroups : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060101D1 RID: 66001 RVA: 0x0017BD78 File Offset: 0x00179F78
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundGroups._ClassPtr;
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x060101D2 RID: 66002 RVA: 0x0017BD84 File Offset: 0x00179F84
		// (set) Token: 0x060101D3 RID: 66003 RVA: 0x0017BDBD File Offset: 0x00179FBD
		public TArray<FSoundGroup> SoundGroupProfiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundGroup> result;
				if ((result = this._SoundGroupProfiles) == null)
				{
					result = (this._SoundGroupProfiles = new TArray<FSoundGroup>(base.NativePtr + (IntPtr)USoundGroups.__PropertyOffset_SoundGroupProfiles, this));
				}
				return result;
			}
			set
			{
				this.SoundGroupProfiles.CopyAssign(value);
			}
		}

		// Token: 0x060101D4 RID: 66004 RVA: 0x0017BDCB File Offset: 0x00179FCB
		static USoundGroups()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundGroups");
		}

		// Token: 0x060101D5 RID: 66005 RVA: 0x0017BDDC File Offset: 0x00179FDC
		protected USoundGroups() : this(BuiltinUtils.AllocNativeUObject(USoundGroups.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060101D6 RID: 66006 RVA: 0x0017BE04 File Offset: 0x0017A004
		protected USoundGroups(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AA5 RID: 35493
		public new const string __ObjectPath = "/Script/Engine.SoundGroups";

		// Token: 0x04008AA6 RID: 35494
		private static IntPtr _ClassPtr;

		// Token: 0x04008AA7 RID: 35495
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AA8 RID: 35496
		internal static int __PropertyOffset_SoundGroupProfiles;

		// Token: 0x04008AA9 RID: 35497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundGroup> _SoundGroupProfiles;
	}
}
