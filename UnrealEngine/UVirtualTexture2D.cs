using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001231 RID: 4657
	[UnrealObjectPath("/Script/Engine.VirtualTexture2D")]
	[UnrealStructLayout(4048, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4048)]
	public class UVirtualTexture2D : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011205 RID: 70149 RVA: 0x0019213A File Offset: 0x0019033A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVirtualTexture2D._ClassPtr;
		}

		// Token: 0x06011206 RID: 70150 RVA: 0x00192148 File Offset: 0x00190348
		public UVirtualTexture2D() : this(BuiltinUtils.AllocNativeUObject(UVirtualTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011207 RID: 70151 RVA: 0x00192170 File Offset: 0x00190370
		[NullableContext(1)]
		public UVirtualTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVirtualTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x06011208 RID: 70152 RVA: 0x001921A3 File Offset: 0x001903A3
		// (set) Token: 0x06011209 RID: 70153 RVA: 0x001921B7 File Offset: 0x001903B7
		public unsafe FVirtualTextureBuildSettings Settings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVirtualTexture2D.__PropertyOffset_Settings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVirtualTexture2D.__PropertyOffset_Settings) = value;
			}
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x0601120A RID: 70154 RVA: 0x001921CC File Offset: 0x001903CC
		// (set) Token: 0x0601120B RID: 70155 RVA: 0x001921DC File Offset: 0x001903DC
		public unsafe bool bContinuousUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVirtualTexture2D.__PropertyOffset_bContinuousUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVirtualTexture2D.__PropertyOffset_bContinuousUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x0601120C RID: 70156 RVA: 0x001921ED File Offset: 0x001903ED
		// (set) Token: 0x0601120D RID: 70157 RVA: 0x001921FD File Offset: 0x001903FD
		public unsafe bool bSinglePhysicalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVirtualTexture2D.__PropertyOffset_bSinglePhysicalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVirtualTexture2D.__PropertyOffset_bSinglePhysicalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601120E RID: 70158 RVA: 0x0019220E File Offset: 0x0019040E
		static UVirtualTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VirtualTexture2D");
		}

		// Token: 0x0601120F RID: 70159 RVA: 0x0019221C File Offset: 0x0019041C
		protected UVirtualTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092A3 RID: 37539
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VirtualTexture2D";

		// Token: 0x040092A4 RID: 37540
		private static IntPtr _ClassPtr;

		// Token: 0x040092A5 RID: 37541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092A6 RID: 37542
		internal static int __PropertyOffset_Settings;

		// Token: 0x040092A7 RID: 37543
		internal static int __PropertyOffset_bContinuousUpdate;

		// Token: 0x040092A8 RID: 37544
		internal static int __PropertyOffset_bSinglePhysicalSpace;
	}
}
