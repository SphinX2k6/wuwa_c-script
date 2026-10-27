using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E8A RID: 3722
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialInstanceActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AMaterialInstanceActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C6BE RID: 50878 RVA: 0x001200F5 File Offset: 0x0011E2F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMaterialInstanceActor._ClassPtr;
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x00120104 File Offset: 0x0011E304
		public AMaterialInstanceActor() : this(BuiltinUtils.AllocNativeUObject(AMaterialInstanceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C6C0 RID: 50880 RVA: 0x0012012C File Offset: 0x0011E32C
		public AMaterialInstanceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMaterialInstanceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600C6C1 RID: 50881 RVA: 0x00120160 File Offset: 0x0011E360
		// (set) Token: 0x0600C6C2 RID: 50882 RVA: 0x00120199 File Offset: 0x0011E399
		public TArray<AActor> TargetActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._TargetActors) == null)
				{
					result = (this._TargetActors = new TArray<AActor>(base.NativePtr + (IntPtr)AMaterialInstanceActor.__PropertyOffset_TargetActors, this));
				}
				return result;
			}
			set
			{
				this.TargetActors.CopyAssign(value);
			}
		}

		// Token: 0x0600C6C3 RID: 50883 RVA: 0x001201A7 File Offset: 0x0011E3A7
		static AMaterialInstanceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstanceActor");
		}

		// Token: 0x0600C6C4 RID: 50884 RVA: 0x001201B5 File Offset: 0x0011E3B5
		protected AMaterialInstanceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A77 RID: 27255
		public new const string __ObjectPath = "/Script/Engine.MaterialInstanceActor";

		// Token: 0x04006A78 RID: 27256
		private static IntPtr _ClassPtr;

		// Token: 0x04006A79 RID: 27257
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006A7A RID: 27258
		internal static int __PropertyOffset_TargetActors;

		// Token: 0x04006A7B RID: 27259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _TargetActors;
	}
}
