using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BE5 RID: 3045
	[UnrealObjectPath("/Script/Engine.FontFace")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UFontFace : UObject, IUnrealUObject, IUnrealObject, IFontFaceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060095EC RID: 38380 RVA: 0x000D5BF4 File Offset: 0x000D3DF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFontFace._ClassPtr;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x000D5C00 File Offset: 0x000D3E00
		int IFontFaceInterface.InterfaceOffset()
		{
			return UFontFace.__InterfaceOffset_IFontFaceInterface;
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x000D5C08 File Offset: 0x000D3E08
		public UFontFace() : this(BuiltinUtils.AllocNativeUObject(UFontFace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x000D5C30 File Offset: 0x000D3E30
		[NullableContext(1)]
		public UFontFace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFontFace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x060095F0 RID: 38384 RVA: 0x000D5C63 File Offset: 0x000D3E63
		// (set) Token: 0x060095F1 RID: 38385 RVA: 0x000D5C77 File Offset: 0x000D3E77
		[Nullable(1)]
		public unsafe string SourceFilename
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UFontFace.__PropertyOffset_SourceFilename)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UFontFace.__PropertyOffset_SourceFilename)), value);
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x060095F2 RID: 38386 RVA: 0x000D5C8C File Offset: 0x000D3E8C
		// (set) Token: 0x060095F3 RID: 38387 RVA: 0x000D5C9C File Offset: 0x000D3E9C
		public unsafe EFontHinting Hinting
		{
			get
			{
				return (EFontHinting)(*(base.NativePtr + (IntPtr)UFontFace.__PropertyOffset_Hinting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFontFace.__PropertyOffset_Hinting) = (byte)value;
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x060095F4 RID: 38388 RVA: 0x000D5CAD File Offset: 0x000D3EAD
		// (set) Token: 0x060095F5 RID: 38389 RVA: 0x000D5CBD File Offset: 0x000D3EBD
		public unsafe EFontLoadingPolicy LoadingPolicy
		{
			get
			{
				return (EFontLoadingPolicy)(*(base.NativePtr + (IntPtr)UFontFace.__PropertyOffset_LoadingPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFontFace.__PropertyOffset_LoadingPolicy) = (byte)value;
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x060095F6 RID: 38390 RVA: 0x000D5CCE File Offset: 0x000D3ECE
		// (set) Token: 0x060095F7 RID: 38391 RVA: 0x000D5CDE File Offset: 0x000D3EDE
		public unsafe EFontLayoutMethod LayoutMethod
		{
			get
			{
				return (EFontLayoutMethod)(*(base.NativePtr + (IntPtr)UFontFace.__PropertyOffset_LayoutMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFontFace.__PropertyOffset_LayoutMethod) = (byte)value;
			}
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x000D5CEF File Offset: 0x000D3EEF
		static UFontFace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FontFace");
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x000D5CFD File Offset: 0x000D3EFD
		protected UFontFace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005419 RID: 21529
		internal static int __InterfaceOffset_IFontFaceInterface;

		// Token: 0x0400541A RID: 21530
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.FontFace";

		// Token: 0x0400541B RID: 21531
		private static IntPtr _ClassPtr;

		// Token: 0x0400541C RID: 21532
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400541D RID: 21533
		internal static int __PropertyOffset_SourceFilename;

		// Token: 0x0400541E RID: 21534
		internal static int __PropertyOffset_Hinting;

		// Token: 0x0400541F RID: 21535
		internal static int __PropertyOffset_LoadingPolicy;

		// Token: 0x04005420 RID: 21536
		internal static int __PropertyOffset_LayoutMethod;
	}
}
