using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000454 RID: 1108
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosSolverSettings")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UChaosSolverSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003BD5 RID: 15317 RVA: 0x0005A28B File Offset: 0x0005848B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosSolverSettings._ClassPtr;
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x0005A298 File Offset: 0x00058498
		public UChaosSolverSettings() : this(BuiltinUtils.AllocNativeUObject(UChaosSolverSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x0005A2C0 File Offset: 0x000584C0
		public UChaosSolverSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosSolverSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x0005A2F4 File Offset: 0x000584F4
		// (set) Token: 0x06003BD9 RID: 15321 RVA: 0x0005A32D File Offset: 0x0005852D
		public FSoftClassPath DefaultChaosSolverActorClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._DefaultChaosSolverActorClass) == null)
				{
					result = (this._DefaultChaosSolverActorClass = new FSoftClassPath(base.NativePtr + (IntPtr)UChaosSolverSettings.__PropertyOffset_DefaultChaosSolverActorClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UChaosSolverSettings.__PropertyOffset_DefaultChaosSolverActorClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x0005A34E File Offset: 0x0005854E
		static UChaosSolverSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosSolverSettings");
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x0005A35C File Offset: 0x0005855C
		protected UChaosSolverSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B90 RID: 7056
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosSolverSettings";

		// Token: 0x04001B91 RID: 7057
		private static IntPtr _ClassPtr;

		// Token: 0x04001B92 RID: 7058
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B93 RID: 7059
		internal static int __PropertyOffset_DefaultChaosSolverActorClass;

		// Token: 0x04001B94 RID: 7060
		[Nullable(2)]
		private FSoftClassPath _DefaultChaosSolverActorClass;
	}
}
