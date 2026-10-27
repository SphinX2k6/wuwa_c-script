using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000168 RID: 360
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.CrowdAvoidanceSamplingPattern")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCrowdAvoidanceSamplingPattern : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x00023DE0 File Offset: 0x00021FE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCrowdAvoidanceSamplingPattern._ScriptStructPtr != 0) ? FCrowdAvoidanceSamplingPattern._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.CrowdAvoidanceSamplingPattern", ref FCrowdAvoidanceSamplingPattern._ScriptStructPtr);
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00023E04 File Offset: 0x00022004
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00023E47 File Offset: 0x00022047
		public TArray<float> Angles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Angles) == null)
				{
					result = (this._Angles = new TArray<float>(base.NativePtr + (IntPtr)FCrowdAvoidanceSamplingPattern.__PropertyOffset_Angles, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Angles.CopyAssign(value);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00023E58 File Offset: 0x00022058
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x00023E9B File Offset: 0x0002209B
		public TArray<float> Radii
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Radii) == null)
				{
					result = (this._Radii = new TArray<float>(base.NativePtr + (IntPtr)FCrowdAvoidanceSamplingPattern.__PropertyOffset_Radii, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Radii.CopyAssign(value);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00023EA9 File Offset: 0x000220A9
		public FCrowdAvoidanceSamplingPattern()
		{
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00023EB1 File Offset: 0x000220B1
		public FCrowdAvoidanceSamplingPattern(TArray<float> Angles, TArray<float> Radii)
		{
			this.Angles = Angles;
			this.Radii = Radii;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00023EC7 File Offset: 0x000220C7
		protected override IntPtr GetUStructPtr()
		{
			return FCrowdAvoidanceSamplingPattern.StaticStruct();
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00023ED3 File Offset: 0x000220D3
		[NullableContext(2)]
		public FCrowdAvoidanceSamplingPattern(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00023EDD File Offset: 0x000220DD
		public FCrowdAvoidanceSamplingPattern(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00023EE8 File Offset: 0x000220E8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCrowdAvoidanceSamplingPattern(Pointer, false, true);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00023EF2 File Offset: 0x000220F2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCrowdAvoidanceSamplingPattern(Pointer, MemoryOwner);
		}

		// Token: 0x0400061B RID: 1563
		public const string __ObjectPath = "/Script/AIModule.CrowdAvoidanceSamplingPattern";

		// Token: 0x0400061C RID: 1564
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400061D RID: 1565
		internal static int __PropertyOffset_Angles;

		// Token: 0x0400061E RID: 1566
		[Nullable(2)]
		private TArray<float> _Angles;

		// Token: 0x0400061F RID: 1567
		internal static int __PropertyOffset_Radii;

		// Token: 0x04000620 RID: 1568
		[Nullable(2)]
		private TArray<float> _Radii;
	}
}
