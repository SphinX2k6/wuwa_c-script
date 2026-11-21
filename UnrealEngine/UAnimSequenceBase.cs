using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000180 RID: 384
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSequenceBase")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public abstract class UAnimSequenceBase : UAnimationAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600189B RID: 6299 RVA: 0x0002568C File Offset: 0x0002388C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSequenceBase._ClassPtr;
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x00025698 File Offset: 0x00023898
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x000256D1 File Offset: 0x000238D1
		public TArray<FAnimNotifyEvent> Notifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEvent> result;
				if ((result = this._Notifies) == null)
				{
					result = (this._Notifies = new TArray<FAnimNotifyEvent>(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_Notifies, this));
				}
				return result;
			}
			set
			{
				this.Notifies.CopyAssign(value);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x000256DF File Offset: 0x000238DF
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x000256EF File Offset: 0x000238EF
		public unsafe float SequenceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_SequenceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_SequenceLength) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00025700 File Offset: 0x00023900
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x00025710 File Offset: 0x00023910
		public unsafe float RateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_RateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_RateScale) = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00025721 File Offset: 0x00023921
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x00025735 File Offset: 0x00023935
		public unsafe FName AnimOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_AnimOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_AnimOrigin) = value;
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0002574A File Offset: 0x0002394A
		public float GetPlayLength()
		{
			return UAnimSequenceBase.__GetPlayLength_Internal(base.NativePtr);
		}

		// Token: 0x060018A5 RID: 6309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayLength_Internal(IntPtr @this);

		// Token: 0x060018A6 RID: 6310 RVA: 0x00025757 File Offset: 0x00023957
		static UAnimSequenceBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSequenceBase");
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00025768 File Offset: 0x00023968
		protected UAnimSequenceBase() : this(BuiltinUtils.AllocNativeUObject(UAnimSequenceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00025790 File Offset: 0x00023990
		protected UAnimSequenceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007D1 RID: 2001
		public new const string __ObjectPath = "/Script/Engine.AnimSequenceBase";

		// Token: 0x040007D2 RID: 2002
		private static IntPtr _ClassPtr;

		// Token: 0x040007D3 RID: 2003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007D4 RID: 2004
		internal static int __PropertyOffset_Notifies;

		// Token: 0x040007D5 RID: 2005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _Notifies;

		// Token: 0x040007D6 RID: 2006
		internal static int __PropertyOffset_SequenceLength;

		// Token: 0x040007D7 RID: 2007
		internal static int __PropertyOffset_RateScale;

		// Token: 0x040007D8 RID: 2008
		internal static int __PropertyOffset_AnimOrigin;
	}
}
