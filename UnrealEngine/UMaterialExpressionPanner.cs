using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E07 RID: 3591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPanner")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionPanner : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1FA RID: 49658 RVA: 0x001178BA File Offset: 0x00115ABA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPanner._ClassPtr;
		}

		// Token: 0x0600C1FB RID: 49659 RVA: 0x001178C8 File Offset: 0x00115AC8
		public UMaterialExpressionPanner() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPanner.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1FC RID: 49660 RVA: 0x001178F0 File Offset: 0x00115AF0
		public UMaterialExpressionPanner(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPanner.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0600C1FD RID: 49661 RVA: 0x00117924 File Offset: 0x00115B24
		// (set) Token: 0x0600C1FE RID: 49662 RVA: 0x0011795D File Offset: 0x00115B5D
		public FExpressionInput Coordinate
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinate) == null)
				{
					result = (this._Coordinate = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_Coordinate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_Coordinate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0600C1FF RID: 49663 RVA: 0x00117980 File Offset: 0x00115B80
		// (set) Token: 0x0600C200 RID: 49664 RVA: 0x001179B9 File Offset: 0x00115BB9
		public FExpressionInput Time
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_Time, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600C201 RID: 49665 RVA: 0x001179DC File Offset: 0x00115BDC
		// (set) Token: 0x0600C202 RID: 49666 RVA: 0x00117A15 File Offset: 0x00115C15
		public FExpressionInput Speed
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Speed) == null)
				{
					result = (this._Speed = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_Speed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_Speed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600C203 RID: 49667 RVA: 0x00117A36 File Offset: 0x00115C36
		// (set) Token: 0x0600C204 RID: 49668 RVA: 0x00117A46 File Offset: 0x00115C46
		public unsafe float SpeedX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_SpeedX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_SpeedX) = value;
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600C205 RID: 49669 RVA: 0x00117A57 File Offset: 0x00115C57
		// (set) Token: 0x0600C206 RID: 49670 RVA: 0x00117A67 File Offset: 0x00115C67
		public unsafe float SpeedY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_SpeedY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_SpeedY) = value;
			}
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600C207 RID: 49671 RVA: 0x00117A78 File Offset: 0x00115C78
		// (set) Token: 0x0600C208 RID: 49672 RVA: 0x00117A88 File Offset: 0x00115C88
		public unsafe uint ConstCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_ConstCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_ConstCoordinate) = (int)value;
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600C209 RID: 49673 RVA: 0x00117A99 File Offset: 0x00115C99
		// (set) Token: 0x0600C20A RID: 49674 RVA: 0x00117AA9 File Offset: 0x00115CA9
		public unsafe bool bFractionalPart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_bFractionalPart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPanner.__PropertyOffset_bFractionalPart) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x00117ABA File Offset: 0x00115CBA
		static UMaterialExpressionPanner()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPanner");
		}

		// Token: 0x0600C20C RID: 49676 RVA: 0x00117AC8 File Offset: 0x00115CC8
		protected UMaterialExpressionPanner(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006734 RID: 26420
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPanner";

		// Token: 0x04006735 RID: 26421
		private static IntPtr _ClassPtr;

		// Token: 0x04006736 RID: 26422
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006737 RID: 26423
		internal static int __PropertyOffset_Coordinate;

		// Token: 0x04006738 RID: 26424
		[Nullable(2)]
		private FExpressionInput _Coordinate;

		// Token: 0x04006739 RID: 26425
		internal static int __PropertyOffset_Time;

		// Token: 0x0400673A RID: 26426
		[Nullable(2)]
		private FExpressionInput _Time;

		// Token: 0x0400673B RID: 26427
		internal static int __PropertyOffset_Speed;

		// Token: 0x0400673C RID: 26428
		[Nullable(2)]
		private FExpressionInput _Speed;

		// Token: 0x0400673D RID: 26429
		internal static int __PropertyOffset_SpeedX;

		// Token: 0x0400673E RID: 26430
		internal static int __PropertyOffset_SpeedY;

		// Token: 0x0400673F RID: 26431
		internal static int __PropertyOffset_ConstCoordinate;

		// Token: 0x04006740 RID: 26432
		internal static int __PropertyOffset_bFractionalPart;
	}
}
