using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D2F RID: 7471
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Pull")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_Buff_Pull : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA6A RID: 117354 RVA: 0x002A5AD7 File Offset: 0x002A3CD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Pull._ClassPtr;
		}

		// Token: 0x0601CA6B RID: 117355 RVA: 0x002A5AE4 File Offset: 0x002A3CE4
		public UKSC_Buff_Pull() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Pull.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA6C RID: 117356 RVA: 0x002A5B0C File Offset: 0x002A3D0C
		[NullableContext(1)]
		public UKSC_Buff_Pull(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Pull.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007349 RID: 29513
		// (get) Token: 0x0601CA6D RID: 117357 RVA: 0x002A5B3F File Offset: 0x002A3D3F
		// (set) Token: 0x0601CA6E RID: 117358 RVA: 0x002A5B53 File Offset: 0x002A3D53
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Pull DaBuffPull_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Pull>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Pull.__PropertyOffset_DaBuffPull_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Pull.__PropertyOffset_DaBuffPull_, value);
			}
		}

		// Token: 0x0601CA6F RID: 117359 RVA: 0x002A5B68 File Offset: 0x002A3D68
		static UKSC_Buff_Pull()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Pull");
		}

		// Token: 0x0601CA70 RID: 117360 RVA: 0x002A5B76 File Offset: 0x002A3D76
		protected UKSC_Buff_Pull(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F884 RID: 63620
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Pull";

		// Token: 0x0400F885 RID: 63621
		private static IntPtr _ClassPtr;

		// Token: 0x0400F886 RID: 63622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F887 RID: 63623
		internal static int __PropertyOffset_DaBuffPull_;
	}
}
