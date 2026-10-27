using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A85 RID: 10885
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseGroupValueCookedData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FWwiseGroupValueCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602820D RID: 164365 RVA: 0x003D10DC File Offset: 0x003CF2DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseGroupValueCookedData._ScriptStructPtr != 0) ? FWwiseGroupValueCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseGroupValueCookedData", ref FWwiseGroupValueCookedData._ScriptStructPtr);
		}

		// Token: 0x1700992E RID: 39214
		// (get) Token: 0x0602820E RID: 164366 RVA: 0x003D1100 File Offset: 0x003CF300
		// (set) Token: 0x0602820F RID: 164367 RVA: 0x003D1110 File Offset: 0x003CF310
		public unsafe EWwiseGroupType Type
		{
			get
			{
				return (EWwiseGroupType)(*(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x1700992F RID: 39215
		// (get) Token: 0x06028210 RID: 164368 RVA: 0x003D1121 File Offset: 0x003CF321
		// (set) Token: 0x06028211 RID: 164369 RVA: 0x003D1131 File Offset: 0x003CF331
		public unsafe int GroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_GroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_GroupId) = value;
			}
		}

		// Token: 0x17009930 RID: 39216
		// (get) Token: 0x06028212 RID: 164370 RVA: 0x003D1142 File Offset: 0x003CF342
		// (set) Token: 0x06028213 RID: 164371 RVA: 0x003D1152 File Offset: 0x003CF352
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17009931 RID: 39217
		// (get) Token: 0x06028214 RID: 164372 RVA: 0x003D1163 File Offset: 0x003CF363
		// (set) Token: 0x06028215 RID: 164373 RVA: 0x003D1177 File Offset: 0x003CF377
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGroupValueCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x06028216 RID: 164374 RVA: 0x003D118C File Offset: 0x003CF38C
		public FWwiseGroupValueCookedData()
		{
		}

		// Token: 0x06028217 RID: 164375 RVA: 0x003D1194 File Offset: 0x003CF394
		public FWwiseGroupValueCookedData(EWwiseGroupType Type, int GroupId, int Id, FName DebugName)
		{
			this.Type = Type;
			this.GroupId = GroupId;
			this.Id = Id;
			this.DebugName = DebugName;
		}

		// Token: 0x06028218 RID: 164376 RVA: 0x003D11B9 File Offset: 0x003CF3B9
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseGroupValueCookedData.StaticStruct();
		}

		// Token: 0x06028219 RID: 164377 RVA: 0x003D11C5 File Offset: 0x003CF3C5
		[NullableContext(2)]
		public FWwiseGroupValueCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602821A RID: 164378 RVA: 0x003D11CF File Offset: 0x003CF3CF
		public FWwiseGroupValueCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602821B RID: 164379 RVA: 0x003D11DA File Offset: 0x003CF3DA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseGroupValueCookedData(Pointer, false, true);
		}

		// Token: 0x0602821C RID: 164380 RVA: 0x003D11E4 File Offset: 0x003CF3E4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseGroupValueCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016045 RID: 90181
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseGroupValueCookedData";

		// Token: 0x04016046 RID: 90182
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016047 RID: 90183
		internal static int __PropertyOffset_Type;

		// Token: 0x04016048 RID: 90184
		internal static int __PropertyOffset_GroupId;

		// Token: 0x04016049 RID: 90185
		internal static int __PropertyOffset_Id;

		// Token: 0x0401604A RID: 90186
		internal static int __PropertyOffset_DebugName;
	}
}
