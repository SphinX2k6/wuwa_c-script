using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002082 RID: 8322
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUILevelSequenceBindings")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLGUILevelSequenceBindings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F65C RID: 128604 RVA: 0x002EA0A2 File Offset: 0x002E82A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUILevelSequenceBindings._ScriptStructPtr != 0) ? FLGUILevelSequenceBindings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUILevelSequenceBindings", ref FLGUILevelSequenceBindings._ScriptStructPtr);
		}

		// Token: 0x17007BF1 RID: 31729
		// (get) Token: 0x0601F65D RID: 128605 RVA: 0x002EA0C8 File Offset: 0x002E82C8
		// (set) Token: 0x0601F65E RID: 128606 RVA: 0x002EA10B File Offset: 0x002E830B
		public TMap<FGuid, UObject> BindingsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, UObject> result;
				if ((result = this._BindingsMap) == null)
				{
					result = (this._BindingsMap = new TMap<FGuid, UObject>(base.NativePtr + (IntPtr)FLGUILevelSequenceBindings.__PropertyOffset_BindingsMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BindingsMap.CopyAssign(value);
			}
		}

		// Token: 0x0601F65F RID: 128607 RVA: 0x002EA119 File Offset: 0x002E8319
		public FLGUILevelSequenceBindings()
		{
		}

		// Token: 0x0601F660 RID: 128608 RVA: 0x002EA121 File Offset: 0x002E8321
		public FLGUILevelSequenceBindings(TMap<FGuid, UObject> BindingsMap)
		{
			this.BindingsMap = BindingsMap;
		}

		// Token: 0x0601F661 RID: 128609 RVA: 0x002EA130 File Offset: 0x002E8330
		protected override IntPtr GetUStructPtr()
		{
			return FLGUILevelSequenceBindings.StaticStruct();
		}

		// Token: 0x0601F662 RID: 128610 RVA: 0x002EA13C File Offset: 0x002E833C
		[NullableContext(2)]
		public FLGUILevelSequenceBindings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F663 RID: 128611 RVA: 0x002EA146 File Offset: 0x002E8346
		public FLGUILevelSequenceBindings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F664 RID: 128612 RVA: 0x002EA151 File Offset: 0x002E8351
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUILevelSequenceBindings(Pointer, false, true);
		}

		// Token: 0x0601F665 RID: 128613 RVA: 0x002EA15B File Offset: 0x002E835B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUILevelSequenceBindings(Pointer, MemoryOwner);
		}

		// Token: 0x04010F54 RID: 69460
		public const string __ObjectPath = "/Script/LGUI.LGUILevelSequenceBindings";

		// Token: 0x04010F55 RID: 69461
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F56 RID: 69462
		internal static int __PropertyOffset_BindingsMap;

		// Token: 0x04010F57 RID: 69463
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, UObject> _BindingsMap;
	}
}
