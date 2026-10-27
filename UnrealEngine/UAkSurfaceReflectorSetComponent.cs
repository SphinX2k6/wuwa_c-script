using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024A RID: 586
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkSurfaceReflectorSetComponent")]
	[UnrealStructLayout(880, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 880)]
	public class UAkSurfaceReflectorSetComponent : UAkAcousticTextureSetComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x00033504 File Offset: 0x00031704
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSurfaceReflectorSetComponent._ClassPtr;
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00033510 File Offset: 0x00031710
		public UAkSurfaceReflectorSetComponent() : this(BuiltinUtils.AllocNativeUObject(UAkSurfaceReflectorSetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00033538 File Offset: 0x00031738
		public UAkSurfaceReflectorSetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSurfaceReflectorSetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0003356B File Offset: 0x0003176B
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0003357B File Offset: 0x0003177B
		public unsafe bool bEnableSurfaceReflectors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_bEnableSurfaceReflectors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_bEnableSurfaceReflectors) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0003358C File Offset: 0x0003178C
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x000335C5 File Offset: 0x000317C5
		public TArray<FAkSurfacePoly> AcousticPolys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAkSurfacePoly> result;
				if ((result = this._AcousticPolys) == null)
				{
					result = (this._AcousticPolys = new TArray<FAkSurfacePoly>(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_AcousticPolys, this));
				}
				return result;
			}
			set
			{
				this.AcousticPolys.CopyAssign(value);
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x000335D3 File Offset: 0x000317D3
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x000335E3 File Offset: 0x000317E3
		public unsafe bool bEnableDiffraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_bEnableDiffraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_bEnableDiffraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x000335F4 File Offset: 0x000317F4
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x00033604 File Offset: 0x00031804
		public unsafe bool bEnableDiffractionOnBoundaryEdges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_bEnableDiffractionOnBoundaryEdges) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSurfaceReflectorSetComponent.__PropertyOffset_bEnableDiffractionOnBoundaryEdges) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00033615 File Offset: 0x00031815
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00033629 File Offset: 0x00031829
		[Nullable(2)]
		public unsafe AActor AssociatedRoom
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAkSurfaceReflectorSetComponent.__PropertyOffset_AssociatedRoom);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkSurfaceReflectorSetComponent.__PropertyOffset_AssociatedRoom, value);
			}
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0003363E File Offset: 0x0003183E
		public void UpdateSurfaceReflectorSet()
		{
			UAkSurfaceReflectorSetComponent.__UpdateSurfaceReflectorSet_Internal(base.NativePtr);
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x0003364B File Offset: 0x0003184B
		public void UpdateAcousticProperties([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FAkSurfacePoly> in_AcousticPolys)
		{
			UAkSurfaceReflectorSetComponent.__UpdateAcousticProperties_Internal(base.NativePtr, (in_AcousticPolys ?? new TArray<FAkSurfacePoly>()).NativePtr);
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00033667 File Offset: 0x00031867
		public void SendSurfaceReflectorSet()
		{
			UAkSurfaceReflectorSetComponent.__SendSurfaceReflectorSet_Internal(base.NativePtr);
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00033674 File Offset: 0x00031874
		public void RemoveSurfaceReflectorSet()
		{
			UAkSurfaceReflectorSetComponent.__RemoveSurfaceReflectorSet_Internal(base.NativePtr);
		}

		// Token: 0x060022B6 RID: 8886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSurfaceReflectorSet_Internal(IntPtr @this);

		// Token: 0x060022B7 RID: 8887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateAcousticProperties_Internal(IntPtr @this, IntPtr in_AcousticPolys);

		// Token: 0x060022B8 RID: 8888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendSurfaceReflectorSet_Internal(IntPtr @this);

		// Token: 0x060022B9 RID: 8889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSurfaceReflectorSet_Internal(IntPtr @this);

		// Token: 0x060022BA RID: 8890 RVA: 0x00033681 File Offset: 0x00031881
		static UAkSurfaceReflectorSetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSurfaceReflectorSetComponent");
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0003368F File Offset: 0x0003188F
		protected UAkSurfaceReflectorSetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BF4 RID: 3060
		public new const string __ObjectPath = "/Script/AkAudio.AkSurfaceReflectorSetComponent";

		// Token: 0x04000BF5 RID: 3061
		private static IntPtr _ClassPtr;

		// Token: 0x04000BF6 RID: 3062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BF7 RID: 3063
		internal static int __PropertyOffset_bEnableSurfaceReflectors;

		// Token: 0x04000BF8 RID: 3064
		internal static int __PropertyOffset_AcousticPolys;

		// Token: 0x04000BF9 RID: 3065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAkSurfacePoly> _AcousticPolys;

		// Token: 0x04000BFA RID: 3066
		internal static int __PropertyOffset_bEnableDiffraction;

		// Token: 0x04000BFB RID: 3067
		internal static int __PropertyOffset_bEnableDiffractionOnBoundaryEdges;

		// Token: 0x04000BFC RID: 3068
		internal static int __PropertyOffset_AssociatedRoom;
	}
}
