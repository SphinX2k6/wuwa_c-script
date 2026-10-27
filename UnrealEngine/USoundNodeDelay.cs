using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200113E RID: 4414
	[UnrealObjectPath("/Script/Engine.SoundNodeDelay")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USoundNodeDelay : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601023B RID: 66107 RVA: 0x0017C7CE File Offset: 0x0017A9CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeDelay._ClassPtr;
		}

		// Token: 0x0601023C RID: 66108 RVA: 0x0017C7DC File Offset: 0x0017A9DC
		public USoundNodeDelay() : this(BuiltinUtils.AllocNativeUObject(USoundNodeDelay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601023D RID: 66109 RVA: 0x0017C804 File Offset: 0x0017AA04
		[NullableContext(1)]
		public USoundNodeDelay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeDelay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0601023E RID: 66110 RVA: 0x0017C837 File Offset: 0x0017AA37
		// (set) Token: 0x0601023F RID: 66111 RVA: 0x0017C847 File Offset: 0x0017AA47
		public unsafe float DelayMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeDelay.__PropertyOffset_DelayMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeDelay.__PropertyOffset_DelayMin) = value;
			}
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x06010240 RID: 66112 RVA: 0x0017C858 File Offset: 0x0017AA58
		// (set) Token: 0x06010241 RID: 66113 RVA: 0x0017C868 File Offset: 0x0017AA68
		public unsafe float DelayMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeDelay.__PropertyOffset_DelayMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeDelay.__PropertyOffset_DelayMax) = value;
			}
		}

		// Token: 0x06010242 RID: 66114 RVA: 0x0017C879 File Offset: 0x0017AA79
		static USoundNodeDelay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeDelay");
		}

		// Token: 0x06010243 RID: 66115 RVA: 0x0017C887 File Offset: 0x0017AA87
		protected USoundNodeDelay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AE5 RID: 35557
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeDelay";

		// Token: 0x04008AE6 RID: 35558
		private static IntPtr _ClassPtr;

		// Token: 0x04008AE7 RID: 35559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AE8 RID: 35560
		internal static int __PropertyOffset_DelayMin;

		// Token: 0x04008AE9 RID: 35561
		internal static int __PropertyOffset_DelayMax;
	}
}
