using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001294 RID: 4756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WpMapCheckInfoForJson")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FWpMapCheckInfoForJson : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601174F RID: 71503 RVA: 0x0019A0EA File Offset: 0x001982EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWpMapCheckInfoForJson._ScriptStructPtr != 0) ? FWpMapCheckInfoForJson._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WpMapCheckInfoForJson", ref FWpMapCheckInfoForJson._ScriptStructPtr);
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x06011750 RID: 71504 RVA: 0x0019A10E File Offset: 0x0019830E
		// (set) Token: 0x06011751 RID: 71505 RVA: 0x0019A122 File Offset: 0x00198322
		public unsafe FName WorldName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWpMapCheckInfoForJson.__PropertyOffset_WorldName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWpMapCheckInfoForJson.__PropertyOffset_WorldName) = value;
			}
		}

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x06011752 RID: 71506 RVA: 0x0019A138 File Offset: 0x00198338
		// (set) Token: 0x06011753 RID: 71507 RVA: 0x0019A17B File Offset: 0x0019837B
		public TArray<FWpMapCheckInfo> MapCheckInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWpMapCheckInfo> result;
				if ((result = this._MapCheckInfos) == null)
				{
					result = (this._MapCheckInfos = new TArray<FWpMapCheckInfo>(base.NativePtr + (IntPtr)FWpMapCheckInfoForJson.__PropertyOffset_MapCheckInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapCheckInfos.CopyAssign(value);
			}
		}

		// Token: 0x06011754 RID: 71508 RVA: 0x0019A189 File Offset: 0x00198389
		public FWpMapCheckInfoForJson()
		{
		}

		// Token: 0x06011755 RID: 71509 RVA: 0x0019A191 File Offset: 0x00198391
		public FWpMapCheckInfoForJson(FName WorldName, TArray<FWpMapCheckInfo> MapCheckInfos)
		{
			this.WorldName = WorldName;
			this.MapCheckInfos = MapCheckInfos;
		}

		// Token: 0x06011756 RID: 71510 RVA: 0x0019A1A7 File Offset: 0x001983A7
		protected override IntPtr GetUStructPtr()
		{
			return FWpMapCheckInfoForJson.StaticStruct();
		}

		// Token: 0x06011757 RID: 71511 RVA: 0x0019A1B3 File Offset: 0x001983B3
		[NullableContext(2)]
		public FWpMapCheckInfoForJson(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011758 RID: 71512 RVA: 0x0019A1BD File Offset: 0x001983BD
		public FWpMapCheckInfoForJson(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011759 RID: 71513 RVA: 0x0019A1C8 File Offset: 0x001983C8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWpMapCheckInfoForJson(Pointer, false, true);
		}

		// Token: 0x0601175A RID: 71514 RVA: 0x0019A1D2 File Offset: 0x001983D2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWpMapCheckInfoForJson(Pointer, MemoryOwner);
		}

		// Token: 0x04009584 RID: 38276
		public const string __ObjectPath = "/Script/Engine.WpMapCheckInfoForJson";

		// Token: 0x04009585 RID: 38277
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009586 RID: 38278
		internal static int __PropertyOffset_WorldName;

		// Token: 0x04009587 RID: 38279
		internal static int __PropertyOffset_MapCheckInfos;

		// Token: 0x04009588 RID: 38280
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWpMapCheckInfo> _MapCheckInfos;
	}
}
