using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E7 RID: 2023
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimationTexture2D")]
	[UnrealStructLayout(4112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4112)]
	public class UAnimationTexture2D : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006BD4 RID: 27604 RVA: 0x0009B1CE File Offset: 0x000993CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimationTexture2D._ClassPtr;
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x0009B1DC File Offset: 0x000993DC
		public UAnimationTexture2D() : this(BuiltinUtils.AllocNativeUObject(UAnimationTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x0009B204 File Offset: 0x00099404
		public UAnimationTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimationTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x0009B237 File Offset: 0x00099437
		// (set) Token: 0x06006BD8 RID: 27608 RVA: 0x0009B247 File Offset: 0x00099447
		public unsafe int StartFrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_StartFrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_StartFrameIndex) = value;
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x0009B258 File Offset: 0x00099458
		// (set) Token: 0x06006BDA RID: 27610 RVA: 0x0009B268 File Offset: 0x00099468
		public unsafe int EndFrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_EndFrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_EndFrameIndex) = value;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x0009B279 File Offset: 0x00099479
		// (set) Token: 0x06006BDC RID: 27612 RVA: 0x0009B289 File Offset: 0x00099489
		public unsafe int CurrentSectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_CurrentSectionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_CurrentSectionIndex) = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x0009B29A File Offset: 0x0009949A
		// (set) Token: 0x06006BDE RID: 27614 RVA: 0x0009B2AA File Offset: 0x000994AA
		public unsafe float FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06006BDF RID: 27615 RVA: 0x0009B2BC File Offset: 0x000994BC
		// (set) Token: 0x06006BE0 RID: 27616 RVA: 0x0009B2F5 File Offset: 0x000994F5
		public TArray<FAnimationTexture2DLOD> LODs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimationTexture2DLOD> result;
				if ((result = this._LODs) == null)
				{
					result = (this._LODs = new TArray<FAnimationTexture2DLOD>(base.NativePtr + (IntPtr)UAnimationTexture2D.__PropertyOffset_LODs, this));
				}
				return result;
			}
			set
			{
				this.LODs.CopyAssign(value);
			}
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x0009B303 File Offset: 0x00099503
		static UAnimationTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimationTexture2D");
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x0009B311 File Offset: 0x00099511
		protected UAnimationTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033E2 RID: 13282
		public new const string __ObjectPath = "/Script/Engine.AnimationTexture2D";

		// Token: 0x040033E3 RID: 13283
		private static IntPtr _ClassPtr;

		// Token: 0x040033E4 RID: 13284
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033E5 RID: 13285
		internal static int __PropertyOffset_StartFrameIndex;

		// Token: 0x040033E6 RID: 13286
		internal static int __PropertyOffset_EndFrameIndex;

		// Token: 0x040033E7 RID: 13287
		internal static int __PropertyOffset_CurrentSectionIndex;

		// Token: 0x040033E8 RID: 13288
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x040033E9 RID: 13289
		internal static int __PropertyOffset_LODs;

		// Token: 0x040033EA RID: 13290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimationTexture2DLOD> _LODs;
	}
}
