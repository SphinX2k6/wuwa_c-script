using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001164 RID: 4452
	[UnrealObjectPath("/Script/Engine.SparseVolumeTextureFrame")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class USparseVolumeTextureFrame : USparseVolumeTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010448 RID: 66632 RVA: 0x0017F7A1 File Offset: 0x0017D9A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USparseVolumeTextureFrame._ClassPtr;
		}

		// Token: 0x06010449 RID: 66633 RVA: 0x0017F7B0 File Offset: 0x0017D9B0
		public USparseVolumeTextureFrame() : this(BuiltinUtils.AllocNativeUObject(USparseVolumeTextureFrame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601044A RID: 66634 RVA: 0x0017F7D8 File Offset: 0x0017D9D8
		[NullableContext(1)]
		public USparseVolumeTextureFrame(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USparseVolumeTextureFrame.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x0601044B RID: 66635 RVA: 0x0017F80B File Offset: 0x0017DA0B
		// (set) Token: 0x0601044C RID: 66636 RVA: 0x0017F81F File Offset: 0x0017DA1F
		[Nullable(2)]
		public unsafe USparseVolumeTexture Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USparseVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + USparseVolumeTextureFrame.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USparseVolumeTextureFrame.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0601044D RID: 66637 RVA: 0x0017F834 File Offset: 0x0017DA34
		// (set) Token: 0x0601044E RID: 66638 RVA: 0x0017F844 File Offset: 0x0017DA44
		public unsafe int FrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USparseVolumeTextureFrame.__PropertyOffset_FrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureFrame.__PropertyOffset_FrameIndex) = value;
			}
		}

		// Token: 0x0601044F RID: 66639 RVA: 0x0017F855 File Offset: 0x0017DA55
		static USparseVolumeTextureFrame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SparseVolumeTextureFrame");
		}

		// Token: 0x06010450 RID: 66640 RVA: 0x0017F863 File Offset: 0x0017DA63
		protected USparseVolumeTextureFrame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C06 RID: 35846
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SparseVolumeTextureFrame";

		// Token: 0x04008C07 RID: 35847
		private static IntPtr _ClassPtr;

		// Token: 0x04008C08 RID: 35848
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C09 RID: 35849
		internal static int __PropertyOffset_Owner;

		// Token: 0x04008C0A RID: 35850
		internal static int __PropertyOffset_FrameIndex;
	}
}
