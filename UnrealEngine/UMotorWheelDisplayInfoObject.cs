using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001679 RID: 5753
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.MotorWheelDisplayInfoObject")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMotorWheelDisplayInfoObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014DEB RID: 85483 RVA: 0x001EAEB0 File Offset: 0x001E90B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMotorWheelDisplayInfoObject._ClassPtr;
		}

		// Token: 0x06014DEC RID: 85484 RVA: 0x001EAEBC File Offset: 0x001E90BC
		public UMotorWheelDisplayInfoObject() : this(BuiltinUtils.AllocNativeUObject(UMotorWheelDisplayInfoObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014DED RID: 85485 RVA: 0x001EAEE4 File Offset: 0x001E90E4
		public UMotorWheelDisplayInfoObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMotorWheelDisplayInfoObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170052A8 RID: 21160
		// (get) Token: 0x06014DEE RID: 85486 RVA: 0x001EAF18 File Offset: 0x001E9118
		// (set) Token: 0x06014DEF RID: 85487 RVA: 0x001EAF51 File Offset: 0x001E9151
		public TArray<FMotorWheelDisplayInfo> DisplayInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMotorWheelDisplayInfo> result;
				if ((result = this._DisplayInfos) == null)
				{
					result = (this._DisplayInfos = new TArray<FMotorWheelDisplayInfo>(base.NativePtr + (IntPtr)UMotorWheelDisplayInfoObject.__PropertyOffset_DisplayInfos, this));
				}
				return result;
			}
			set
			{
				this.DisplayInfos.CopyAssign(value);
			}
		}

		// Token: 0x06014DF0 RID: 85488 RVA: 0x001EAF5F File Offset: 0x001E915F
		static UMotorWheelDisplayInfoObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.MotorWheelDisplayInfoObject");
		}

		// Token: 0x06014DF1 RID: 85489 RVA: 0x001EAF6D File Offset: 0x001E916D
		protected UMotorWheelDisplayInfoObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B5F4 RID: 46580
		public new const string __ObjectPath = "/Script/KuroAnim.MotorWheelDisplayInfoObject";

		// Token: 0x0400B5F5 RID: 46581
		private static IntPtr _ClassPtr;

		// Token: 0x0400B5F6 RID: 46582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B5F7 RID: 46583
		internal static int __PropertyOffset_DisplayInfos;

		// Token: 0x0400B5F8 RID: 46584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMotorWheelDisplayInfo> _DisplayInfos;
	}
}
