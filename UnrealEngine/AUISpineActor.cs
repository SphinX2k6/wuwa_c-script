using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B4 RID: 8628
	[UnrealObjectPath("/Script/LGUI.UISpineActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUISpineActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D29 RID: 134441 RVA: 0x00307F49 File Offset: 0x00306149
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUISpineActor._ClassPtr;
		}

		// Token: 0x06020D2A RID: 134442 RVA: 0x00307F58 File Offset: 0x00306158
		public AUISpineActor() : this(BuiltinUtils.AllocNativeUObject(AUISpineActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D2B RID: 134443 RVA: 0x00307F80 File Offset: 0x00306180
		[NullableContext(1)]
		public AUISpineActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUISpineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008033 RID: 32819
		// (get) Token: 0x06020D2C RID: 134444 RVA: 0x00307FB3 File Offset: 0x003061B3
		// (set) Token: 0x06020D2D RID: 134445 RVA: 0x00307FC7 File Offset: 0x003061C7
		[Nullable(2)]
		public unsafe UUISpineRenderable UISpine
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISpineRenderable>(base.NativePtr / (IntPtr)sizeof(void*) + AUISpineActor.__PropertyOffset_UISpine);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUISpineActor.__PropertyOffset_UISpine, value);
			}
		}

		// Token: 0x06020D2E RID: 134446 RVA: 0x00307FDC File Offset: 0x003061DC
		static AUISpineActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpineActor");
		}

		// Token: 0x06020D2F RID: 134447 RVA: 0x00307FEA File Offset: 0x003061EA
		protected AUISpineActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011883 RID: 71811
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpineActor";

		// Token: 0x04011884 RID: 71812
		private static IntPtr _ClassPtr;

		// Token: 0x04011885 RID: 71813
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011886 RID: 71814
		internal static int __PropertyOffset_UISpine;
	}
}
