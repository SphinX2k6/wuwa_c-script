using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A07 RID: 10759
	[UnrealObjectPath("/Script/UMG.WidgetTransform")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FWidgetTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028012 RID: 163858 RVA: 0x003CE695 File Offset: 0x003CC895
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetTransform._ScriptStructPtr != 0) ? FWidgetTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.WidgetTransform", ref FWidgetTransform._ScriptStructPtr);
		}

		// Token: 0x170098CF RID: 39119
		// (get) Token: 0x06028013 RID: 163859 RVA: 0x003CE6B9 File Offset: 0x003CC8B9
		// (set) Token: 0x06028014 RID: 163860 RVA: 0x003CE6CD File Offset: 0x003CC8CD
		public unsafe FVector2D Translation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Translation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Translation) = value;
			}
		}

		// Token: 0x170098D0 RID: 39120
		// (get) Token: 0x06028015 RID: 163861 RVA: 0x003CE6E2 File Offset: 0x003CC8E2
		// (set) Token: 0x06028016 RID: 163862 RVA: 0x003CE6F6 File Offset: 0x003CC8F6
		public unsafe FVector2D Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170098D1 RID: 39121
		// (get) Token: 0x06028017 RID: 163863 RVA: 0x003CE70B File Offset: 0x003CC90B
		// (set) Token: 0x06028018 RID: 163864 RVA: 0x003CE71F File Offset: 0x003CC91F
		public unsafe FVector2D Shear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Shear);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Shear) = value;
			}
		}

		// Token: 0x170098D2 RID: 39122
		// (get) Token: 0x06028019 RID: 163865 RVA: 0x003CE734 File Offset: 0x003CC934
		// (set) Token: 0x0602801A RID: 163866 RVA: 0x003CE744 File Offset: 0x003CC944
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetTransform.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x0602801B RID: 163867 RVA: 0x003CE755 File Offset: 0x003CC955
		public FWidgetTransform()
		{
		}

		// Token: 0x0602801C RID: 163868 RVA: 0x003CE75D File Offset: 0x003CC95D
		public FWidgetTransform(FVector2D Translation, FVector2D Scale, FVector2D Shear, float Angle)
		{
			this.Translation = Translation;
			this.Scale = Scale;
			this.Shear = Shear;
			this.Angle = Angle;
		}

		// Token: 0x0602801D RID: 163869 RVA: 0x003CE782 File Offset: 0x003CC982
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetTransform.StaticStruct();
		}

		// Token: 0x0602801E RID: 163870 RVA: 0x003CE78E File Offset: 0x003CC98E
		[NullableContext(2)]
		public FWidgetTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602801F RID: 163871 RVA: 0x003CE798 File Offset: 0x003CC998
		public FWidgetTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028020 RID: 163872 RVA: 0x003CE7A3 File Offset: 0x003CC9A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetTransform(Pointer, false, true);
		}

		// Token: 0x06028021 RID: 163873 RVA: 0x003CE7AD File Offset: 0x003CC9AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04015D4E RID: 89422
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetTransform";

		// Token: 0x04015D4F RID: 89423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015D50 RID: 89424
		internal static int __PropertyOffset_Translation;

		// Token: 0x04015D51 RID: 89425
		internal static int __PropertyOffset_Scale;

		// Token: 0x04015D52 RID: 89426
		internal static int __PropertyOffset_Shear;

		// Token: 0x04015D53 RID: 89427
		internal static int __PropertyOffset_Angle;
	}
}
