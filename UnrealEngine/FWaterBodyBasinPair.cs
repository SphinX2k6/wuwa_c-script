using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024B7 RID: 9399
	[UnrealObjectPath("/Script/NavigationSystem.WaterBodyBasinPair")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FWaterBodyBasinPair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602332B RID: 144171 RVA: 0x003410F6 File Offset: 0x0033F2F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWaterBodyBasinPair._ScriptStructPtr != 0) ? FWaterBodyBasinPair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.WaterBodyBasinPair", ref FWaterBodyBasinPair._ScriptStructPtr);
		}

		// Token: 0x1700875E RID: 34654
		// (get) Token: 0x0602332C RID: 144172 RVA: 0x0034111A File Offset: 0x0033F31A
		// (set) Token: 0x0602332D RID: 144173 RVA: 0x0034112A File Offset: 0x0033F32A
		public unsafe int BodyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBodyBasinPair.__PropertyOffset_BodyId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBodyBasinPair.__PropertyOffset_BodyId) = value;
			}
		}

		// Token: 0x1700875F RID: 34655
		// (get) Token: 0x0602332E RID: 144174 RVA: 0x0034113B File Offset: 0x0033F33B
		// (set) Token: 0x0602332F RID: 144175 RVA: 0x0034114B File Offset: 0x0033F34B
		public unsafe int Basin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBodyBasinPair.__PropertyOffset_Basin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBodyBasinPair.__PropertyOffset_Basin) = value;
			}
		}

		// Token: 0x06023330 RID: 144176 RVA: 0x0034115C File Offset: 0x0033F35C
		public FWaterBodyBasinPair()
		{
		}

		// Token: 0x06023331 RID: 144177 RVA: 0x00341164 File Offset: 0x0033F364
		public FWaterBodyBasinPair(int BodyId, int Basin)
		{
			this.BodyId = BodyId;
			this.Basin = Basin;
		}

		// Token: 0x06023332 RID: 144178 RVA: 0x0034117A File Offset: 0x0033F37A
		protected override IntPtr GetUStructPtr()
		{
			return FWaterBodyBasinPair.StaticStruct();
		}

		// Token: 0x06023333 RID: 144179 RVA: 0x00341186 File Offset: 0x0033F386
		[NullableContext(2)]
		public FWaterBodyBasinPair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023334 RID: 144180 RVA: 0x00341190 File Offset: 0x0033F390
		public FWaterBodyBasinPair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023335 RID: 144181 RVA: 0x0034119B File Offset: 0x0033F39B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWaterBodyBasinPair(Pointer, false, true);
		}

		// Token: 0x06023336 RID: 144182 RVA: 0x003411A5 File Offset: 0x0033F3A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWaterBodyBasinPair(Pointer, MemoryOwner);
		}

		// Token: 0x04012CC7 RID: 76999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.WaterBodyBasinPair";

		// Token: 0x04012CC8 RID: 77000
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012CC9 RID: 77001
		internal static int __PropertyOffset_BodyId;

		// Token: 0x04012CCA RID: 77002
		internal static int __PropertyOffset_Basin;
	}
}
