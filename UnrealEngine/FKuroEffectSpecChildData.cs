using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003E9 RID: 1001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSpecChildData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectSpecChildData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061FC RID: 25084 RVA: 0x0008C1EF File Offset: 0x0008A3EF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectSpecChildData._ScriptStructPtr != 0) ? FKuroEffectSpecChildData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectSpecChildData", ref FKuroEffectSpecChildData._ScriptStructPtr);
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x0008C213 File Offset: 0x0008A413
		// (set) Token: 0x060061FE RID: 25086 RVA: 0x0008C223 File Offset: 0x0008A423
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectSpecChildData.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectSpecChildData.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x0008C234 File Offset: 0x0008A434
		// (set) Token: 0x06006200 RID: 25088 RVA: 0x0008C277 File Offset: 0x0008A477
		public TArray<int> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<int>(base.NativePtr + (IntPtr)FKuroEffectSpecChildData.__PropertyOffset_Children, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x0008C285 File Offset: 0x0008A485
		public FKuroEffectSpecChildData()
		{
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x0008C28D File Offset: 0x0008A48D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectSpecChildData.StaticStruct();
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x0008C299 File Offset: 0x0008A499
		[NullableContext(2)]
		public FKuroEffectSpecChildData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x0008C2A3 File Offset: 0x0008A4A3
		public FKuroEffectSpecChildData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x0008C2AE File Offset: 0x0008A4AE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectSpecChildData(Pointer, false, true);
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x0008C2B8 File Offset: 0x0008A4B8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectSpecChildData(Pointer, MemoryOwner);
		}

		// Token: 0x040029BA RID: 10682
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSpecChildData";

		// Token: 0x040029BB RID: 10683
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029BC RID: 10684
		internal static int __PropertyOffset_Id;

		// Token: 0x040029BD RID: 10685
		internal static int __PropertyOffset_Children;

		// Token: 0x040029BE RID: 10686
		[Nullable(2)]
		private TArray<int> _Children;
	}
}
