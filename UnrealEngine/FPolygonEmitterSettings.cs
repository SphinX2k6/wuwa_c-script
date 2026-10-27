using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001709 RID: 5897
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.PolygonEmitterSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FPolygonEmitterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601549B RID: 87195 RVA: 0x001F49BA File Offset: 0x001F2BBA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPolygonEmitterSettings._ScriptStructPtr != 0) ? FPolygonEmitterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.PolygonEmitterSettings", ref FPolygonEmitterSettings._ScriptStructPtr);
		}

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x0601549C RID: 87196 RVA: 0x001F49DE File Offset: 0x001F2BDE
		// (set) Token: 0x0601549D RID: 87197 RVA: 0x001F49EE File Offset: 0x001F2BEE
		public unsafe int PolygonSides
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_PolygonSides);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_PolygonSides) = value;
			}
		}

		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x0601549E RID: 87198 RVA: 0x001F49FF File Offset: 0x001F2BFF
		// (set) Token: 0x0601549F RID: 87199 RVA: 0x001F4A0F File Offset: 0x001F2C0F
		public unsafe float InnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_InnerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_InnerRadius) = value;
			}
		}

		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x060154A0 RID: 87200 RVA: 0x001F4A20 File Offset: 0x001F2C20
		// (set) Token: 0x060154A1 RID: 87201 RVA: 0x001F4A30 File Offset: 0x001F2C30
		public unsafe int FillSides
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_FillSides);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_FillSides) = value;
			}
		}

		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x060154A2 RID: 87202 RVA: 0x001F4A44 File Offset: 0x001F2C44
		// (set) Token: 0x060154A3 RID: 87203 RVA: 0x001F4A87 File Offset: 0x001F2C87
		public FEmitterStackSettings StackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterStackSettings result;
				if ((result = this._StackSettings) == null)
				{
					result = (this._StackSettings = new FEmitterStackSettings(base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_StackSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterStackSettings.StaticStruct(), base.NativePtr + (IntPtr)FPolygonEmitterSettings.__PropertyOffset_StackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060154A4 RID: 87204 RVA: 0x001F4AA8 File Offset: 0x001F2CA8
		public FPolygonEmitterSettings()
		{
		}

		// Token: 0x060154A5 RID: 87205 RVA: 0x001F4AB0 File Offset: 0x001F2CB0
		public FPolygonEmitterSettings(int PolygonSides, float InnerRadius, int FillSides, FEmitterStackSettings StackSettings)
		{
			this.PolygonSides = PolygonSides;
			this.InnerRadius = InnerRadius;
			this.FillSides = FillSides;
			this.StackSettings = StackSettings;
		}

		// Token: 0x060154A6 RID: 87206 RVA: 0x001F4AD5 File Offset: 0x001F2CD5
		protected override IntPtr GetUStructPtr()
		{
			return FPolygonEmitterSettings.StaticStruct();
		}

		// Token: 0x060154A7 RID: 87207 RVA: 0x001F4AE1 File Offset: 0x001F2CE1
		[NullableContext(2)]
		public FPolygonEmitterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060154A8 RID: 87208 RVA: 0x001F4AEB File Offset: 0x001F2CEB
		public FPolygonEmitterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060154A9 RID: 87209 RVA: 0x001F4AF6 File Offset: 0x001F2CF6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPolygonEmitterSettings(Pointer, false, true);
		}

		// Token: 0x060154AA RID: 87210 RVA: 0x001F4B00 File Offset: 0x001F2D00
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPolygonEmitterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B9A8 RID: 47528
		public const string __ObjectPath = "/Script/KuroBulletCore.PolygonEmitterSettings";

		// Token: 0x0400B9A9 RID: 47529
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B9AA RID: 47530
		internal static int __PropertyOffset_PolygonSides;

		// Token: 0x0400B9AB RID: 47531
		internal static int __PropertyOffset_InnerRadius;

		// Token: 0x0400B9AC RID: 47532
		internal static int __PropertyOffset_FillSides;

		// Token: 0x0400B9AD RID: 47533
		internal static int __PropertyOffset_StackSettings;

		// Token: 0x0400B9AE RID: 47534
		[Nullable(2)]
		private FEmitterStackSettings _StackSettings;
	}
}
