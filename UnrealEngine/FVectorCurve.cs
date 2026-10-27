using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200121E RID: 4638
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VectorCurve")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class FVectorCurve : FAnimCurveBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601112D RID: 69933 RVA: 0x00190E93 File Offset: 0x0018F093
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorCurve._ScriptStructPtr != 0) ? FVectorCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VectorCurve", ref FVectorCurve._ScriptStructPtr);
		}

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0601112E RID: 69934 RVA: 0x00190EB8 File Offset: 0x0018F0B8
		// (set) Token: 0x0601112F RID: 69935 RVA: 0x00190EFC File Offset: 0x0018F0FC
		public TFixedArray<FRichCurve> FloatCurves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FRichCurve> result;
				if ((result = this._FloatCurves) == null)
				{
					result = (this._FloatCurves = new TFixedArray<FRichCurve>(base.NativePtr + (IntPtr)FVectorCurve.__PropertyOffset_FloatCurves, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatCurves.CopyAssign(value);
			}
		}

		// Token: 0x06011130 RID: 69936 RVA: 0x00190F0A File Offset: 0x0018F10A
		public FVectorCurve()
		{
		}

		// Token: 0x06011131 RID: 69937 RVA: 0x00190F12 File Offset: 0x0018F112
		public FVectorCurve(TFixedArray<FRichCurve> FloatCurves, FName LastObservedName_DEPRECATED, FSmartName Name, FLinearColor Color, int CurveTypeFlags)
		{
			this.FloatCurves = FloatCurves;
			base.LastObservedName_DEPRECATED = LastObservedName_DEPRECATED;
			base.Name = Name;
			base.CurveTypeFlags = CurveTypeFlags;
		}

		// Token: 0x06011132 RID: 69938 RVA: 0x00190F37 File Offset: 0x0018F137
		protected override IntPtr GetUStructPtr()
		{
			return FVectorCurve.StaticStruct();
		}

		// Token: 0x06011133 RID: 69939 RVA: 0x00190F43 File Offset: 0x0018F143
		[NullableContext(2)]
		public FVectorCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011134 RID: 69940 RVA: 0x00190F4D File Offset: 0x0018F14D
		public FVectorCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011135 RID: 69941 RVA: 0x00190F58 File Offset: 0x0018F158
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorCurve(Pointer, false, true);
		}

		// Token: 0x06011136 RID: 69942 RVA: 0x00190F62 File Offset: 0x0018F162
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04009241 RID: 37441
		public new const string __ObjectPath = "/Script/Engine.VectorCurve";

		// Token: 0x04009242 RID: 37442
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009243 RID: 37443
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x04009244 RID: 37444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRichCurve> _FloatCurves;
	}
}
