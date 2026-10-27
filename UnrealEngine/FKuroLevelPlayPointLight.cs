using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018F0 RID: 6384
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayPointLight")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroLevelPlayPointLight : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017AD0 RID: 96976 RVA: 0x0022B286 File Offset: 0x00229486
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlayPointLight._ScriptStructPtr != 0) ? FKuroLevelPlayPointLight._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelPlayPointLight", ref FKuroLevelPlayPointLight._ScriptStructPtr);
		}

		// Token: 0x17005F64 RID: 24420
		// (get) Token: 0x06017AD1 RID: 96977 RVA: 0x0022B2AA File Offset: 0x002294AA
		// (set) Token: 0x06017AD2 RID: 96978 RVA: 0x0022B2BA File Offset: 0x002294BA
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005F65 RID: 24421
		// (get) Token: 0x06017AD3 RID: 96979 RVA: 0x0022B2CB File Offset: 0x002294CB
		// (set) Token: 0x06017AD4 RID: 96980 RVA: 0x0022B2DB File Offset: 0x002294DB
		public unsafe bool bLit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_bLit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_bLit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F66 RID: 24422
		// (get) Token: 0x06017AD5 RID: 96981 RVA: 0x0022B2EC File Offset: 0x002294EC
		// (set) Token: 0x06017AD6 RID: 96982 RVA: 0x0022B300 File Offset: 0x00229500
		public unsafe FVectorDouble Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x06017AD7 RID: 96983 RVA: 0x0022B315 File Offset: 0x00229515
		public FKuroLevelPlayPointLight()
		{
		}

		// Token: 0x06017AD8 RID: 96984 RVA: 0x0022B31D File Offset: 0x0022951D
		public FKuroLevelPlayPointLight(float Radius, bool bLit, FVectorDouble Position)
		{
			this.Radius = Radius;
			this.bLit = bLit;
			this.Position = Position;
		}

		// Token: 0x06017AD9 RID: 96985 RVA: 0x0022B33A File Offset: 0x0022953A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlayPointLight.StaticStruct();
		}

		// Token: 0x06017ADA RID: 96986 RVA: 0x0022B346 File Offset: 0x00229546
		[NullableContext(2)]
		public FKuroLevelPlayPointLight(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017ADB RID: 96987 RVA: 0x0022B350 File Offset: 0x00229550
		public FKuroLevelPlayPointLight(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017ADC RID: 96988 RVA: 0x0022B35B File Offset: 0x0022955B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlayPointLight(Pointer, false, true);
		}

		// Token: 0x06017ADD RID: 96989 RVA: 0x0022B365 File Offset: 0x00229565
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlayPointLight(Pointer, MemoryOwner);
		}

		// Token: 0x0400CDB7 RID: 52663
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayPointLight";

		// Token: 0x0400CDB8 RID: 52664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CDB9 RID: 52665
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400CDBA RID: 52666
		internal static int __PropertyOffset_bLit;

		// Token: 0x0400CDBB RID: 52667
		internal static int __PropertyOffset_Position;
	}
}
