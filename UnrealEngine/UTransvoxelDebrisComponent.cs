using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001201 RID: 4609
	[UnrealObjectPath("/Script/Engine.TransvoxelDebrisComponent")]
	[UnrealStructLayout(1680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UTransvoxelDebrisComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010FDC RID: 69596 RVA: 0x0018EFDB File Offset: 0x0018D1DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransvoxelDebrisComponent._ClassPtr;
		}

		// Token: 0x06010FDD RID: 69597 RVA: 0x0018EFE8 File Offset: 0x0018D1E8
		public UTransvoxelDebrisComponent() : this(BuiltinUtils.AllocNativeUObject(UTransvoxelDebrisComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010FDE RID: 69598 RVA: 0x0018F010 File Offset: 0x0018D210
		[NullableContext(1)]
		public UTransvoxelDebrisComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransvoxelDebrisComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x06010FDF RID: 69599 RVA: 0x0018F043 File Offset: 0x0018D243
		// (set) Token: 0x06010FE0 RID: 69600 RVA: 0x0018F053 File Offset: 0x0018D253
		public unsafe bool bRenderingEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelDebrisComponent.__PropertyOffset_bRenderingEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelDebrisComponent.__PropertyOffset_bRenderingEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06010FE1 RID: 69601 RVA: 0x0018F064 File Offset: 0x0018D264
		static UTransvoxelDebrisComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TransvoxelDebrisComponent");
		}

		// Token: 0x06010FE2 RID: 69602 RVA: 0x0018F072 File Offset: 0x0018D272
		protected UTransvoxelDebrisComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009192 RID: 37266
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TransvoxelDebrisComponent";

		// Token: 0x04009193 RID: 37267
		private static IntPtr _ClassPtr;

		// Token: 0x04009194 RID: 37268
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009195 RID: 37269
		internal static int __PropertyOffset_bRenderingEnabled;
	}
}
