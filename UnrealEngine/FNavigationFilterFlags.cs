using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200248D RID: 9357
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationFilterFlags")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FNavigationFilterFlags : IEqualityOperators<FNavigationFilterFlags, FNavigationFilterFlags, bool>, IEquatable<FNavigationFilterFlags>, IUnrealScriptStruct
	{
		// Token: 0x06022FE9 RID: 143337 RVA: 0x0033BCE4 File Offset: 0x00339EE4
		public FNavigationFilterFlags(bool bNavFlag0, bool bNavFlag1, bool bNavFlag2, bool bNavFlag3, bool bNavFlag4, bool bNavFlag5, bool bNavFlag6, bool bNavFlag7, bool bNavFlag8, bool bNavFlag9, bool bNavFlag10, bool bNavFlag11, bool bNavFlag12, bool bNavFlag13, bool bNavFlag14, bool bNavFlag15)
		{
			this.__DummyField0 = (byte)(((bNavFlag0 > false) ? 1 : 0) | (bNavFlag1 ? 2 : 0) | (bNavFlag2 ? 4 : 0) | (bNavFlag3 ? 8 : 0) | (bNavFlag4 ? 16 : 0) | (bNavFlag5 ? 32 : 0) | (bNavFlag6 ? 64 : 0) | (bNavFlag7 ? 128 : 0));
			this.__DummyField1 = (byte)(((bNavFlag8 > false) ? 1 : 0) | (bNavFlag9 ? 2 : 0) | (bNavFlag10 ? 4 : 0) | (bNavFlag11 ? 8 : 0) | (bNavFlag12 ? 16 : 0) | (bNavFlag13 ? 32 : 0) | (bNavFlag14 ? 64 : 0) | (bNavFlag15 ? 128 : 0));
		}

		// Token: 0x1700866D RID: 34413
		// (get) Token: 0x06022FEA RID: 143338 RVA: 0x0033BD92 File Offset: 0x00339F92
		// (set) Token: 0x06022FEB RID: 143339 RVA: 0x0033BD9F File Offset: 0x00339F9F
		public bool bNavFlag0
		{
			get
			{
				return (this.__DummyField0 & 1) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 254) | ((value > false) ? 1 : 0));
			}
		}

		// Token: 0x1700866E RID: 34414
		// (get) Token: 0x06022FEC RID: 143340 RVA: 0x0033BDB9 File Offset: 0x00339FB9
		// (set) Token: 0x06022FED RID: 143341 RVA: 0x0033BDC6 File Offset: 0x00339FC6
		public bool bNavFlag1
		{
			get
			{
				return (this.__DummyField0 & 2) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 253) | (value ? 2 : 0));
			}
		}

		// Token: 0x1700866F RID: 34415
		// (get) Token: 0x06022FEE RID: 143342 RVA: 0x0033BDE3 File Offset: 0x00339FE3
		// (set) Token: 0x06022FEF RID: 143343 RVA: 0x0033BDF0 File Offset: 0x00339FF0
		public bool bNavFlag2
		{
			get
			{
				return (this.__DummyField0 & 4) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 251) | (value ? 4 : 0));
			}
		}

		// Token: 0x17008670 RID: 34416
		// (get) Token: 0x06022FF0 RID: 143344 RVA: 0x0033BE0D File Offset: 0x0033A00D
		// (set) Token: 0x06022FF1 RID: 143345 RVA: 0x0033BE1A File Offset: 0x0033A01A
		public bool bNavFlag3
		{
			get
			{
				return (this.__DummyField0 & 8) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 247) | (value ? 8 : 0));
			}
		}

		// Token: 0x17008671 RID: 34417
		// (get) Token: 0x06022FF2 RID: 143346 RVA: 0x0033BE37 File Offset: 0x0033A037
		// (set) Token: 0x06022FF3 RID: 143347 RVA: 0x0033BE45 File Offset: 0x0033A045
		public bool bNavFlag4
		{
			get
			{
				return (this.__DummyField0 & 16) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 239) | (value ? 16 : 0));
			}
		}

		// Token: 0x17008672 RID: 34418
		// (get) Token: 0x06022FF4 RID: 143348 RVA: 0x0033BE63 File Offset: 0x0033A063
		// (set) Token: 0x06022FF5 RID: 143349 RVA: 0x0033BE71 File Offset: 0x0033A071
		public bool bNavFlag5
		{
			get
			{
				return (this.__DummyField0 & 32) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 223) | (value ? 32 : 0));
			}
		}

		// Token: 0x17008673 RID: 34419
		// (get) Token: 0x06022FF6 RID: 143350 RVA: 0x0033BE8F File Offset: 0x0033A08F
		// (set) Token: 0x06022FF7 RID: 143351 RVA: 0x0033BE9D File Offset: 0x0033A09D
		public bool bNavFlag6
		{
			get
			{
				return (this.__DummyField0 & 64) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 191) | (value ? 64 : 0));
			}
		}

		// Token: 0x17008674 RID: 34420
		// (get) Token: 0x06022FF8 RID: 143352 RVA: 0x0033BEBB File Offset: 0x0033A0BB
		// (set) Token: 0x06022FF9 RID: 143353 RVA: 0x0033BECC File Offset: 0x0033A0CC
		public bool bNavFlag7
		{
			get
			{
				return (this.__DummyField0 & 128) > 0;
			}
			set
			{
				this.__DummyField0 = ((this.__DummyField0 & 127) | (value ? 128 : 0));
			}
		}

		// Token: 0x17008675 RID: 34421
		// (get) Token: 0x06022FFA RID: 143354 RVA: 0x0033BEEA File Offset: 0x0033A0EA
		// (set) Token: 0x06022FFB RID: 143355 RVA: 0x0033BEF7 File Offset: 0x0033A0F7
		public bool bNavFlag8
		{
			get
			{
				return (this.__DummyField1 & 1) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 254) | ((value > false) ? 1 : 0));
			}
		}

		// Token: 0x17008676 RID: 34422
		// (get) Token: 0x06022FFC RID: 143356 RVA: 0x0033BF11 File Offset: 0x0033A111
		// (set) Token: 0x06022FFD RID: 143357 RVA: 0x0033BF1E File Offset: 0x0033A11E
		public bool bNavFlag9
		{
			get
			{
				return (this.__DummyField1 & 2) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 253) | (value ? 2 : 0));
			}
		}

		// Token: 0x17008677 RID: 34423
		// (get) Token: 0x06022FFE RID: 143358 RVA: 0x0033BF3B File Offset: 0x0033A13B
		// (set) Token: 0x06022FFF RID: 143359 RVA: 0x0033BF48 File Offset: 0x0033A148
		public bool bNavFlag10
		{
			get
			{
				return (this.__DummyField1 & 4) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 251) | (value ? 4 : 0));
			}
		}

		// Token: 0x17008678 RID: 34424
		// (get) Token: 0x06023000 RID: 143360 RVA: 0x0033BF65 File Offset: 0x0033A165
		// (set) Token: 0x06023001 RID: 143361 RVA: 0x0033BF72 File Offset: 0x0033A172
		public bool bNavFlag11
		{
			get
			{
				return (this.__DummyField1 & 8) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 247) | (value ? 8 : 0));
			}
		}

		// Token: 0x17008679 RID: 34425
		// (get) Token: 0x06023002 RID: 143362 RVA: 0x0033BF8F File Offset: 0x0033A18F
		// (set) Token: 0x06023003 RID: 143363 RVA: 0x0033BF9D File Offset: 0x0033A19D
		public bool bNavFlag12
		{
			get
			{
				return (this.__DummyField1 & 16) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 239) | (value ? 16 : 0));
			}
		}

		// Token: 0x1700867A RID: 34426
		// (get) Token: 0x06023004 RID: 143364 RVA: 0x0033BFBB File Offset: 0x0033A1BB
		// (set) Token: 0x06023005 RID: 143365 RVA: 0x0033BFC9 File Offset: 0x0033A1C9
		public bool bNavFlag13
		{
			get
			{
				return (this.__DummyField1 & 32) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 223) | (value ? 32 : 0));
			}
		}

		// Token: 0x1700867B RID: 34427
		// (get) Token: 0x06023006 RID: 143366 RVA: 0x0033BFE7 File Offset: 0x0033A1E7
		// (set) Token: 0x06023007 RID: 143367 RVA: 0x0033BFF5 File Offset: 0x0033A1F5
		public bool bNavFlag14
		{
			get
			{
				return (this.__DummyField1 & 64) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 191) | (value ? 64 : 0));
			}
		}

		// Token: 0x1700867C RID: 34428
		// (get) Token: 0x06023008 RID: 143368 RVA: 0x0033C013 File Offset: 0x0033A213
		// (set) Token: 0x06023009 RID: 143369 RVA: 0x0033C024 File Offset: 0x0033A224
		public bool bNavFlag15
		{
			get
			{
				return (this.__DummyField1 & 128) > 0;
			}
			set
			{
				this.__DummyField1 = ((this.__DummyField1 & 127) | (value ? 128 : 0));
			}
		}

		// Token: 0x0602300A RID: 143370 RVA: 0x0033C042 File Offset: 0x0033A242
		public static bool operator ==(FNavigationFilterFlags left, FNavigationFilterFlags right)
		{
			return left.__DummyField0 == right.__DummyField0 && left.__DummyField1 == right.__DummyField1;
		}

		// Token: 0x0602300B RID: 143371 RVA: 0x0033C062 File Offset: 0x0033A262
		public static bool operator !=(FNavigationFilterFlags left, FNavigationFilterFlags right)
		{
			return !(left == right);
		}

		// Token: 0x0602300C RID: 143372 RVA: 0x0033C06E File Offset: 0x0033A26E
		public bool Equals(FNavigationFilterFlags other)
		{
			return this == other;
		}

		// Token: 0x0602300D RID: 143373 RVA: 0x0033C07C File Offset: 0x0033A27C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNavigationFilterFlags)
			{
				FNavigationFilterFlags other = (FNavigationFilterFlags)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602300E RID: 143374 RVA: 0x0033C0A4 File Offset: 0x0033A2A4
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<bool>(this.bNavFlag0);
			hashCode.Add<bool>(this.bNavFlag1);
			hashCode.Add<bool>(this.bNavFlag2);
			hashCode.Add<bool>(this.bNavFlag3);
			hashCode.Add<bool>(this.bNavFlag4);
			hashCode.Add<bool>(this.bNavFlag5);
			hashCode.Add<bool>(this.bNavFlag6);
			hashCode.Add<bool>(this.bNavFlag7);
			hashCode.Add<bool>(this.bNavFlag8);
			hashCode.Add<bool>(this.bNavFlag9);
			hashCode.Add<bool>(this.bNavFlag10);
			hashCode.Add<bool>(this.bNavFlag11);
			hashCode.Add<bool>(this.bNavFlag12);
			hashCode.Add<bool>(this.bNavFlag13);
			hashCode.Add<bool>(this.bNavFlag14);
			hashCode.Add<bool>(this.bNavFlag15);
			return hashCode.ToHashCode();
		}

		// Token: 0x0602300F RID: 143375 RVA: 0x0033C190 File Offset: 0x0033A390
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavigationFilterFlags._ScriptStructPtr != 0) ? FNavigationFilterFlags._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavigationFilterFlags", ref FNavigationFilterFlags._ScriptStructPtr);
		}

		// Token: 0x04012B03 RID: 76547
		[FieldOffset(0)]
		private byte __DummyField0;

		// Token: 0x04012B04 RID: 76548
		[FieldOffset(1)]
		private byte __DummyField1;

		// Token: 0x04012B05 RID: 76549
		public const string __ObjectPath = "/Script/NavigationSystem.NavigationFilterFlags";

		// Token: 0x04012B06 RID: 76550
		private static IntPtr _ScriptStructPtr;
	}
}
