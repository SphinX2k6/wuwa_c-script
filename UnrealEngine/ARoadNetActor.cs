using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D5 RID: 9941
	[UnrealObjectPath("/Script/RoadNetRuntime.RoadNetActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ARoadNetActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E59 RID: 151129 RVA: 0x00369354 File Offset: 0x00367554
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARoadNetActor._ClassPtr;
		}

		// Token: 0x06024E5A RID: 151130 RVA: 0x00369360 File Offset: 0x00367560
		public ARoadNetActor() : this(BuiltinUtils.AllocNativeUObject(ARoadNetActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E5B RID: 151131 RVA: 0x00369388 File Offset: 0x00367588
		[NullableContext(1)]
		public ARoadNetActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARoadNetActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E7D RID: 36477
		// (get) Token: 0x06024E5C RID: 151132 RVA: 0x003693BB File Offset: 0x003675BB
		// (set) Token: 0x06024E5D RID: 151133 RVA: 0x003693CF File Offset: 0x003675CF
		[Nullable(2)]
		public unsafe URoadNetComponent RoadNetComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URoadNetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ARoadNetActor.__PropertyOffset_RoadNetComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ARoadNetActor.__PropertyOffset_RoadNetComponent, value);
			}
		}

		// Token: 0x06024E5E RID: 151134 RVA: 0x003693E4 File Offset: 0x003675E4
		static ARoadNetActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetRuntime.RoadNetActor");
		}

		// Token: 0x06024E5F RID: 151135 RVA: 0x003693F2 File Offset: 0x003675F2
		protected ARoadNetActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E08 RID: 81416
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RoadNetRuntime.RoadNetActor";

		// Token: 0x04013E09 RID: 81417
		private static IntPtr _ClassPtr;

		// Token: 0x04013E0A RID: 81418
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E0B RID: 81419
		internal static int __PropertyOffset_RoadNetComponent;
	}
}
