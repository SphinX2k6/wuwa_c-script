using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002630 RID: 9776
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PacketHandler.PacketHandlerProfileConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPacketHandlerProfileConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245B1 RID: 148913 RVA: 0x0035D3D6 File Offset: 0x0035B5D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPacketHandlerProfileConfig._ClassPtr;
		}

		// Token: 0x060245B2 RID: 148914 RVA: 0x0035D3E4 File Offset: 0x0035B5E4
		public UPacketHandlerProfileConfig() : this(BuiltinUtils.AllocNativeUObject(UPacketHandlerProfileConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245B3 RID: 148915 RVA: 0x0035D40C File Offset: 0x0035B60C
		public UPacketHandlerProfileConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPacketHandlerProfileConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C14 RID: 35860
		// (get) Token: 0x060245B4 RID: 148916 RVA: 0x0035D440 File Offset: 0x0035B640
		// (set) Token: 0x060245B5 RID: 148917 RVA: 0x0035D479 File Offset: 0x0035B679
		public TArray<string> Components
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TArray<string>(base.NativePtr + (IntPtr)UPacketHandlerProfileConfig.__PropertyOffset_Components, this));
				}
				return result;
			}
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x060245B6 RID: 148918 RVA: 0x0035D487 File Offset: 0x0035B687
		static UPacketHandlerProfileConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PacketHandler.PacketHandlerProfileConfig");
		}

		// Token: 0x060245B7 RID: 148919 RVA: 0x0035D495 File Offset: 0x0035B695
		protected UPacketHandlerProfileConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013817 RID: 79895
		public new const string __ObjectPath = "/Script/PacketHandler.PacketHandlerProfileConfig";

		// Token: 0x04013818 RID: 79896
		private static IntPtr _ClassPtr;

		// Token: 0x04013819 RID: 79897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401381A RID: 79898
		internal static int __PropertyOffset_Components;

		// Token: 0x0401381B RID: 79899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Components;
	}
}
