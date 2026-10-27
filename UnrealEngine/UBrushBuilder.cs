using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008F6 RID: 2294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BrushBuilder")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UBrushBuilder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DE6 RID: 32230 RVA: 0x000B46DE File Offset: 0x000B28DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushBuilder._ClassPtr;
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06007DE7 RID: 32231 RVA: 0x000B46EA File Offset: 0x000B28EA
		// (set) Token: 0x06007DE8 RID: 32232 RVA: 0x000B46FE File Offset: 0x000B28FE
		public unsafe string BitmapFilename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBrushBuilder.__PropertyOffset_BitmapFilename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBrushBuilder.__PropertyOffset_BitmapFilename)), value);
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06007DE9 RID: 32233 RVA: 0x000B4713 File Offset: 0x000B2913
		// (set) Token: 0x06007DEA RID: 32234 RVA: 0x000B4727 File Offset: 0x000B2927
		public unsafe string ToolTip
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBrushBuilder.__PropertyOffset_ToolTip)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBrushBuilder.__PropertyOffset_ToolTip)), value);
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06007DEB RID: 32235 RVA: 0x000B473C File Offset: 0x000B293C
		// (set) Token: 0x06007DEC RID: 32236 RVA: 0x000B4755 File Offset: 0x000B2955
		public unsafe bool NotifyBadParams
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_NotifyBadParams) & UBrushBuilder.__PropertyMask_NotifyBadParams) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_NotifyBadParams) = ((*(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_NotifyBadParams) & ~UBrushBuilder.__PropertyMask_NotifyBadParams) | (value ? UBrushBuilder.__PropertyMask_NotifyBadParams : 0));
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x06007DED RID: 32237 RVA: 0x000B4788 File Offset: 0x000B2988
		// (set) Token: 0x06007DEE RID: 32238 RVA: 0x000B47C1 File Offset: 0x000B29C1
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06007DEF RID: 32239 RVA: 0x000B47D0 File Offset: 0x000B29D0
		// (set) Token: 0x06007DF0 RID: 32240 RVA: 0x000B4809 File Offset: 0x000B2A09
		public TArray<FBuilderPoly> Polys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBuilderPoly> result;
				if ((result = this._Polys) == null)
				{
					result = (this._Polys = new TArray<FBuilderPoly>(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_Polys, this));
				}
				return result;
			}
			set
			{
				this.Polys.CopyAssign(value);
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06007DF1 RID: 32241 RVA: 0x000B4817 File Offset: 0x000B2A17
		// (set) Token: 0x06007DF2 RID: 32242 RVA: 0x000B482B File Offset: 0x000B2A2B
		public unsafe FName Layer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_Layer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_Layer) = value;
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06007DF3 RID: 32243 RVA: 0x000B4840 File Offset: 0x000B2A40
		// (set) Token: 0x06007DF4 RID: 32244 RVA: 0x000B4859 File Offset: 0x000B2A59
		public unsafe bool MergeCoplanars
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_MergeCoplanars) & UBrushBuilder.__PropertyMask_MergeCoplanars) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_MergeCoplanars) = ((*(base.NativePtr + (IntPtr)UBrushBuilder.__PropertyOffset_MergeCoplanars) & ~UBrushBuilder.__PropertyMask_MergeCoplanars) | (value ? UBrushBuilder.__PropertyMask_MergeCoplanars : 0));
			}
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x000B4889 File Offset: 0x000B2A89
		static UBrushBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BrushBuilder");
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x000B4898 File Offset: 0x000B2A98
		protected UBrushBuilder() : this(BuiltinUtils.AllocNativeUObject(UBrushBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x000B48C0 File Offset: 0x000B2AC0
		protected UBrushBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003C57 RID: 15447
		public new const string __ObjectPath = "/Script/Engine.BrushBuilder";

		// Token: 0x04003C58 RID: 15448
		private static IntPtr _ClassPtr;

		// Token: 0x04003C59 RID: 15449
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003C5A RID: 15450
		internal static int __PropertyOffset_BitmapFilename;

		// Token: 0x04003C5B RID: 15451
		internal static int __PropertyOffset_ToolTip;

		// Token: 0x04003C5C RID: 15452
		internal static int __PropertyOffset_NotifyBadParams;

		// Token: 0x04003C5D RID: 15453
		internal static byte __PropertyMask_NotifyBadParams;

		// Token: 0x04003C5E RID: 15454
		internal static int __PropertyOffset_Vertices;

		// Token: 0x04003C5F RID: 15455
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x04003C60 RID: 15456
		internal static int __PropertyOffset_Polys;

		// Token: 0x04003C61 RID: 15457
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBuilderPoly> _Polys;

		// Token: 0x04003C62 RID: 15458
		internal static int __PropertyOffset_Layer;

		// Token: 0x04003C63 RID: 15459
		internal static int __PropertyOffset_MergeCoplanars;

		// Token: 0x04003C64 RID: 15460
		internal static byte __PropertyMask_MergeCoplanars;
	}
}
