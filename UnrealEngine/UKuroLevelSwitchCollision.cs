using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B7 RID: 6583
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelSwitchCollision")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroLevelSwitchCollision : UKuroLevelStateAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060187C9 RID: 100297 RVA: 0x00241478 File Offset: 0x0023F678
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelSwitchCollision._ClassPtr;
		}

		// Token: 0x060187CA RID: 100298 RVA: 0x00241484 File Offset: 0x0023F684
		public UKuroLevelSwitchCollision() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSwitchCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060187CB RID: 100299 RVA: 0x002414AC File Offset: 0x0023F6AC
		public UKuroLevelSwitchCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSwitchCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x060187CC RID: 100300 RVA: 0x002414E0 File Offset: 0x0023F6E0
		// (set) Token: 0x060187CD RID: 100301 RVA: 0x00241519 File Offset: 0x0023F719
		public TArray<FKuroLevelSwitchCollisionData> Collisions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelSwitchCollisionData> result;
				if ((result = this._Collisions) == null)
				{
					result = (this._Collisions = new TArray<FKuroLevelSwitchCollisionData>(base.NativePtr + (IntPtr)UKuroLevelSwitchCollision.__PropertyOffset_Collisions, this));
				}
				return result;
			}
			set
			{
				this.Collisions.CopyAssign(value);
			}
		}

		// Token: 0x060187CE RID: 100302 RVA: 0x00241527 File Offset: 0x0023F727
		static UKuroLevelSwitchCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelSwitchCollision");
		}

		// Token: 0x060187CF RID: 100303 RVA: 0x00241535 File Offset: 0x0023F735
		protected UKuroLevelSwitchCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D3A0 RID: 54176
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelSwitchCollision";

		// Token: 0x0400D3A1 RID: 54177
		private static IntPtr _ClassPtr;

		// Token: 0x0400D3A2 RID: 54178
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D3A3 RID: 54179
		internal static int __PropertyOffset_Collisions;

		// Token: 0x0400D3A4 RID: 54180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelSwitchCollisionData> _Collisions;
	}
}
