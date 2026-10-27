using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C85 RID: 3205
	[UnrealObjectPath("/Script/Engine.InterpLookupPoint")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FInterpLookupPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A2A3 RID: 41635 RVA: 0x000E6F72 File Offset: 0x000E5172
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpLookupPoint._ScriptStructPtr != 0) ? FInterpLookupPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InterpLookupPoint", ref FInterpLookupPoint._ScriptStructPtr);
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600A2A4 RID: 41636 RVA: 0x000E6F96 File Offset: 0x000E5196
		// (set) Token: 0x0600A2A5 RID: 41637 RVA: 0x000E6FAA File Offset: 0x000E51AA
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpLookupPoint.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpLookupPoint.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600A2A6 RID: 41638 RVA: 0x000E6FBF File Offset: 0x000E51BF
		// (set) Token: 0x0600A2A7 RID: 41639 RVA: 0x000E6FCF File Offset: 0x000E51CF
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpLookupPoint.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpLookupPoint.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x000E6FE0 File Offset: 0x000E51E0
		public FInterpLookupPoint()
		{
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x000E6FE8 File Offset: 0x000E51E8
		public FInterpLookupPoint(FName GroupName, float Time)
		{
			this.GroupName = GroupName;
			this.Time = Time;
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x000E6FFE File Offset: 0x000E51FE
		protected override IntPtr GetUStructPtr()
		{
			return FInterpLookupPoint.StaticStruct();
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x000E700A File Offset: 0x000E520A
		[NullableContext(2)]
		public FInterpLookupPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x000E7014 File Offset: 0x000E5214
		public FInterpLookupPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x000E701F File Offset: 0x000E521F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpLookupPoint(Pointer, false, true);
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x000E7029 File Offset: 0x000E5229
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpLookupPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04005943 RID: 22851
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpLookupPoint";

		// Token: 0x04005944 RID: 22852
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005945 RID: 22853
		internal static int __PropertyOffset_GroupName;

		// Token: 0x04005946 RID: 22854
		internal static int __PropertyOffset_Time;
	}
}
