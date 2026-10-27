using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028D4 RID: 10452
	[UnrealObjectPath("/Script/T4MRuntime.T4MLandscapeActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AT4MLandscapeActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C7F RID: 158847 RVA: 0x003B258D File Offset: 0x003B078D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AT4MLandscapeActor._ClassPtr;
		}

		// Token: 0x06026C80 RID: 158848 RVA: 0x003B259C File Offset: 0x003B079C
		public AT4MLandscapeActor() : this(BuiltinUtils.AllocNativeUObject(AT4MLandscapeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C81 RID: 158849 RVA: 0x003B25C4 File Offset: 0x003B07C4
		[NullableContext(1)]
		public AT4MLandscapeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AT4MLandscapeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700955F RID: 38239
		// (get) Token: 0x06026C82 RID: 158850 RVA: 0x003B25F7 File Offset: 0x003B07F7
		// (set) Token: 0x06026C83 RID: 158851 RVA: 0x003B260B File Offset: 0x003B080B
		[Nullable(2)]
		public unsafe UT4MLandscapeComponent T4MLandscapeComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UT4MLandscapeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AT4MLandscapeActor.__PropertyOffset_T4MLandscapeComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AT4MLandscapeActor.__PropertyOffset_T4MLandscapeComponent, value);
			}
		}

		// Token: 0x06026C84 RID: 158852 RVA: 0x003B2620 File Offset: 0x003B0820
		static AT4MLandscapeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/T4MRuntime.T4MLandscapeActor");
		}

		// Token: 0x06026C85 RID: 158853 RVA: 0x003B262E File Offset: 0x003B082E
		protected AT4MLandscapeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015498 RID: 87192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/T4MRuntime.T4MLandscapeActor";

		// Token: 0x04015499 RID: 87193
		private static IntPtr _ClassPtr;

		// Token: 0x0401549A RID: 87194
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401549B RID: 87195
		internal static int __PropertyOffset_T4MLandscapeComponent;
	}
}
