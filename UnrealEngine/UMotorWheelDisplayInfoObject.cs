using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000305 RID: 773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.MotorWheelDisplayInfoObject")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMotorWheelDisplayInfoObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600530E RID: 21262 RVA: 0x00074148 File Offset: 0x00072348
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMotorWheelDisplayInfoObject._ClassPtr;
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00074154 File Offset: 0x00072354
		public UMotorWheelDisplayInfoObject() : this(BuiltinUtils.AllocNativeUObject(UMotorWheelDisplayInfoObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0007417C File Offset: 0x0007237C
		public UMotorWheelDisplayInfoObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMotorWheelDisplayInfoObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x000741B0 File Offset: 0x000723B0
		// (set) Token: 0x06005312 RID: 21266 RVA: 0x000741E9 File Offset: 0x000723E9
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

		// Token: 0x06005313 RID: 21267 RVA: 0x000741F7 File Offset: 0x000723F7
		static UMotorWheelDisplayInfoObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.MotorWheelDisplayInfoObject");
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00074205 File Offset: 0x00072405
		protected UMotorWheelDisplayInfoObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021E0 RID: 8672
		public new const string __ObjectPath = "/Script/KuroAnim.MotorWheelDisplayInfoObject";

		// Token: 0x040021E1 RID: 8673
		private static IntPtr _ClassPtr;

		// Token: 0x040021E2 RID: 8674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040021E3 RID: 8675
		internal static int __PropertyOffset_DisplayInfos;

		// Token: 0x040021E4 RID: 8676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMotorWheelDisplayInfo> _DisplayInfos;
	}
}
